
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static eManagerSystem.Application.Catalog.Server.ServerService;

namespace eManagerSystem.Application.Catalog.Server
{
   public interface IServerService 
    {
        event ActiveHandler EventActiveHandler;

        event MessageHandler EventMessageHandler;

        event MessageHandler EventGetFilePathHandler;
        void Connect();
         void SendFile(string filePath);

      
        void SendUser(string option,IEnumerable<object> students);

        void SendUserFromFile(string option, IEnumerable<object> students);

        void SendSubject(string subject);

        void Receive(object obj);

        void Close();

        byte[] GetFilePath(string filePath);

        object Deserialize(byte[] data);

        List<Students> ReadAll(int gradeId);

        IEnumerable<Grade> getAllGrade();

        IEnumerable<Subject> getAllSubject();

        void SaveFile(byte[] data, int dataLength);
        int BeginExam(string inputTime, int counter, System.Timers.Timer countdown);

        void SetIpUser(List<string> listIP);

        void CheckActiveIpUser(string IP,string mssv);

        void SendMessage(string message, string IP,string type);

        void Disconnect();

        void ActiveControlClient();

        string GetServerPath();

        void SetServerPath(string pathName);

        void SendClientPath(string pathName);

        List<string> GetListClientIP();

       void SendDSDeThiMany(List<string> dsDethi);

        void LogOutUser();

        void ShutDownUser();

    }
}
