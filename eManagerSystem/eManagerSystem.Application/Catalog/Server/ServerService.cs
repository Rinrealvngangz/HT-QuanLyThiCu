using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace eManagerSystem.Application.Catalog.Server
{
   public class ServerService  : IServerService 
    {
       
        IPEndPoint IP;
        Socket server;
        List<Socket> clientList;
        List<string> clientIP;
        static string pathName;
          private readonly string strCon = @"SERVER=DESKTOP-4ICDD5V\SQLEXPRESS;Database =ExamManagement;User Id=test;password=nguyenmautuan123";
         // private readonly string strCon = @"SERVER=HAQUOCHUY\HQH;Database =[ExamManagement];Integrated security =true";


        public void Connect()
        {
            clientList = new List<Socket>();
       
        
            IP = new IPEndPoint(IPAddress.Any, 9999);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            server.Bind(IP);

            Thread Listen = new Thread(() =>
            {
                try
                {
                    while (true)
                    {
                        server.Listen(100);
                        Socket client = server.Accept();
                    

                        clientList.Add(client); 
                        Thread receive = new Thread(Receive);
                        receive.IsBackground = true;
                        receive.Start(client);
                    }
                }
                catch
                {
                    IP = new IPEndPoint(IPAddress.Any, 9999);
                    server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                }
              
            });
            Listen.IsBackground = true;
            Listen.Start();
                

        }
        public void SendFile(string filePath)
        {
            foreach( Socket client in clientList)
            {
                if (filePath != String.Empty)
                {
                    SendData sendData = new SendData
                    {
                        option = Serialize("Send File"),
                        data = GetFilePath(filePath)
                    };
                    client.Send(Serialize(sendData));
                   


                }
            }
           
        }
      
        public string Messgase { get; set; }

        public void  Receive(object obj)
        {
            Socket client = obj as Socket;

           
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    client.Receive(data);
                  SendData receiveData = new SendData();
                   receiveData = (SendData)Deserialize(data);
                    switch ((string)Deserialize(receiveData.option))
                    {
                        case "Send Accept":
                            // 192.168.0.1:3000
                            string ipClient = client.RemoteEndPoint.ToString().Split(':')[0];
                            var mssv = (string)Deserialize(receiveData.data);
                            CheckActiveIpUser(ipClient,mssv);
                          
                            break;
                        case "Send Exam":
                            byte[] receiveBylength = (byte[])Deserialize(receiveData.data);
                            EventGetPathNameArgs("OK");
                            SaveFile(receiveBylength, receiveBylength.Length);
                        
                            break;
                        default:
                            break;
                    }

                }

            }
            catch(Exception er)
            {
                throw er;
             //   clientList.Remove(client);
               // client.Close();
            }
        }
     

        public void Close()
        {
            server.Close();
        }

        public byte[] GetFilePath(string filePath)
        {
          //  var name = Path.GetFileName(filePath);
            byte[] fNameByte = Encoding.ASCII.GetBytes(filePath);
            byte[] fileData = File.ReadAllBytes(filePath);
            byte[] serverData = new byte[4 + fNameByte.Length + fileData.Length];
            byte[] fNameLength = BitConverter.GetBytes(fNameByte.Length);
            fNameLength.CopyTo(serverData, 0);
            fNameByte.CopyTo(serverData, 4);
            fileData.CopyTo(serverData,4+fNameByte.Length);
            return serverData;
        }

        public object Deserialize(byte[] data)
        {
            MemoryStream stream = new MemoryStream(data);
            BinaryFormatter formatter = new BinaryFormatter();
           return formatter.Deserialize(stream);
           
        }

        private void hasParameter(SqlCommand cmd, string query, object[] para = null)
        {
            int i = 0;
            foreach (string parameter in query.Split(' ').ToArray().Where(p => p.Contains('@')))
            {
                cmd.Parameters.AddWithValue(parameter, para[i]);

                i++;
            }
        }

        private byte[] Serialize(object data)
        {
            MemoryStream memoryStream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(memoryStream, data);
            memoryStream.Close();
            return memoryStream.ToArray();
        }


        public DataTable ExcuteDataReader(string query, object[] para = null)
        {
            try
            {
                DataTable data = new DataTable();
                using (SqlConnection conn = new SqlConnection(strCon))
                {

                    SqlCommand cmd = new SqlCommand(query, conn);
                    if (para != null)
                    {

                        {
                            hasParameter(cmd, query, para);
                        }

                    }
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(data);


                }
                return data;
            }
            catch (Exception err)
            {
                throw err;
            }

        }

        public IEnumerable<Students> readAll(int gradeId)
        {
            DataTable dataTable = ExcuteDataReader("usp_getAllStudentBySubject @gradeId", new object[] { gradeId });
            List<Students> listStudents = new List<Students>();
            foreach (DataRow row in dataTable.Rows)
            {
                Students students = new Students(row);
                listStudents.Add(students);
            
            }
            return listStudents;
        }

        public List<Students> ReadAll(int gradeId)
        {
            return (List<Students>)readAll(gradeId);
        }

        public IEnumerable<Grade> getAllGrade()
        {
            DataTable dataTable = ExcuteDataReader("usp_getGrade");
            List<Grade> listGrades = new List<Grade>();
            foreach (DataRow row in dataTable.Rows)
            {
                Grade grades = new Grade(row);
                listGrades.Add(grades);

            }
            return listGrades;
        }

   

        public void SendUser(string option,IEnumerable<object> students)
        {
            foreach (Socket client in clientList)
            {
                if (option != String.Empty)
                {
                    SendData sendData = new SendData
                    {
                        option = Serialize("Send User"),
                        data = Serialize(students)
                    };
                    client.Send(Serialize(sendData));
                }
            }
        }

        public IEnumerable<Subject> getAllSubject()
        {
                DataTable dataTable = ExcuteDataReader("usp_getSubjects");
                List<Subject> listSubject = new List<Subject>();
                foreach (DataRow row in dataTable.Rows)
                {
                    Subject subject = new Subject(row);
                    listSubject.Add(subject);

                }
                return (IEnumerable<Subject>)listSubject;
            
        }

        public void SendSubject(string subject)
        {
            foreach (Socket client in clientList)
            {
                if (subject != String.Empty)
                {
                    SendData sendData = new SendData
                    {
                        option = Serialize("Send Subject"),
                        data = Serialize(subject)
                    };
                    client.Send(Serialize(sendData));
                }
            }
        }

        public void SaveFile(byte[] data, int dataLength)
        {
            string pathSave = GetServerPath();
            int fileNameLength = BitConverter.ToInt32(data, 0);
            string nameFile = Encoding.ASCII.GetString(data, 4, fileNameLength);
            string nameFolder = Path.GetFileName(nameFile);
            string root = pathSave+"/" + nameFolder;
            if (!Directory.Exists(root))
            {
                Directory.CreateDirectory(root);
            }
            foreach (string Files in Directory.EnumerateFiles(nameFile))
            {
                string name = root + "/" + Path.GetFileName(Files);
                BinaryWriter writer = new BinaryWriter(File.Open(name, FileMode.Append));
                int count = dataLength - 4 - fileNameLength;
                writer.Write(data, 4 + fileNameLength, count);
            }
           
        }

        public int BeginExam(string inputTime, int counter, System.Timers.Timer countdown)
        {
             int minute = Convert.ToInt32(inputTime);
            counter = minute * 60;
            countdown.Enabled = true;

            SendData sendData = new SendData
            {
                option = Serialize("Send BeginExam"),
                data = Serialize(minute),
            };
             

            foreach (Socket client in clientList)
            {
                try
                {
                    client.Send(Serialize(sendData));
                }
                catch (Exception ex)
                {
                    clientList.Remove(client);
                    client.Close();
                }
            }
            return counter;
        }

    
        public void SetIpUser(List<string> listIP)
        {
            clientIP = new List<string>(listIP);         
        }

        public delegate void ActiveHandler(object sender, ActiveEventArgs args);
        public event ActiveHandler EventActiveHandler;
        public class ActiveEventArgs : EventArgs
        {
            public string mssv { get; set; }
            public string IP { get; set; }

        }
        public void ActiveUser(string MSSV,string ip)
        {
            ActiveEventArgs args = new ActiveEventArgs();

            args.mssv = MSSV;
            args.IP = ip;
            EventActiveHandler.Invoke(this, args);


        }

      
        public void CheckActiveIpUser(string IP,string mssv)
        {
            if (clientIP != null)
            {
                if (clientIP.Any(ip => ip == IP) == true)
                {
                    ActiveUser(mssv,IP);
                    string message = "Chap nhan success!";
                    SendMessage(message, IP, "Success");
                }
                else
                {
                    string message = "Loi dia chi IPAddress";
                    SendMessage(message, IP, "Fail");

                }
            }
         
        }

        public void SendMessage(string message,string IP,string type)
        {
            if(type == "Fail")
            {
                foreach (Socket client in clientList)
                {
                    string ipClient = client.RemoteEndPoint.ToString().Split(':')[0];
                    if (ipClient == IP)
                    {
                        SendData sendData = new SendData
                        {
                            option = Serialize("Send Decline"),
                            data = Serialize(message),
                        };
                        client.Send(Serialize(sendData));
                        clientList.Remove(client);
                        client.Close();
                        break;
                    }
                }
                
            }
            else
            {
               var client = clientList.Where(cli => cli.RemoteEndPoint.ToString().Split(':')[0] == IP).FirstOrDefault();
                   SendData sendData = new SendData
                {
                    option = Serialize("Send Success"),
                    data = Serialize(message),
                };
                client.Send(Serialize(sendData));
            }
         
        }

        public void SendUserFromFile(string option, IEnumerable<object> students)
        {
            foreach (Socket client in clientList)
            {
                if (option != String.Empty)
                {
                    SendData sendData = new SendData
                    {
                        option = Serialize(option),
                        data = Serialize(students)
                    };
                    client.Send(Serialize(sendData));
                }
            }
        }

        public delegate void MessageHandler(object sender, MessageEventArgs args);
        public event MessageHandler EventMessageHandler;
        public class MessageEventArgs : EventArgs
        {
            public string mesage { get; set; }

        }
        public void EventMessageArgs(string mess)
        {
            MessageEventArgs args = new MessageEventArgs();

            args.mesage = mess;
            EventMessageHandler.Invoke(this, args);

        }

        public void Disconnect()
        {
                foreach (var client in clientList)
                {
                 
                    clientList.Remove(client);
                     client.Close();
                    if (clientList.Count == 0)
                    {
                        break;

                    }
                }
                               
            EventMessageArgs("Disconnect success");   
        }

        public void ActiveControlClient()
        {
            foreach (Socket client in clientList)
            {
                SendData sendData = new SendData
                {
                    option = Serialize("Send ActiveControl"),
                    data = Serialize("ActiveUser")
                };
                client.Send(Serialize(sendData));
            }
        }

    
        public event MessageHandler EventGetFilePathHandler;
     
        public void EventGetPathNameArgs(string mess)
        {
            MessageEventArgs args = new MessageEventArgs();

            args.mesage = mess;
            EventGetFilePathHandler.Invoke(this, args);

        }

        public string GetServerPath()
        {
            return pathName;
        }

        public void SetServerPath(string pathNames)
        {
            pathName = pathNames;
        }

        public void SendClientPath(string pathName)
        {
            foreach (Socket client in clientList)
            {
                SendData sendData = new SendData
                {
                    option = Serialize("Send ClientPath"),
                    data = Serialize(pathName)
                };
                client.Send(Serialize(sendData));
            }
        }

        public List<string> GetListClientIP()
        {
            return clientIP;
        }

        public void SendDSDeThiMany(List<string> dsDethi)
        {
            string dethi1 = dsDethi[0];
            string dethi2 = dsDethi[1];
               if(clientIP != null)
            {
                foreach(var item in clientIP.Select((Value, i) =>(Value,i)))
                {
                    var clientIp = item.Value;
                    var client = clientList.Where<Socket>(cli => cli.RemoteEndPoint.ToString().Split(':')[0] == clientIp).FirstOrDefault();
                    
                    if(client != null)
                    {
                        var index = (item.i) + 1;

                        if (index % 2 != 0)
                        {
                            SendFileMany(dethi1, client);
                        }
                        else
                        {
                            SendFileMany(dethi2, client);
                        }
                    }
                       
                }
            }
               
        }

         void SendFileMany(string filePath,Socket client)
        {
            if (filePath != String.Empty)
            {
                SendData sendData = new SendData
                {
                    option = Serialize("Send File"),
                    data = GetFilePath(filePath)
                };
                client.Send(Serialize(sendData));
            }
        }

        public void LogOutUser()
        {
            foreach (Socket client in clientList)
            {
                SendData sendData = new SendData
                {
                    option = Serialize("Send LogOut"),
                    data = Serialize("ok")
                };
                client.Send(Serialize(sendData));
            }
                
            
        }

        public void ShutDownUser()
        {
            foreach (Socket client in clientList)
            {
                SendData sendData = new SendData
                {
                    option = Serialize("Send ShutDown"),
                    data = Serialize("ok")
                };
                client.Send(Serialize(sendData));
            }
        }
    }
}
