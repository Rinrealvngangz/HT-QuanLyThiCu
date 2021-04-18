using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormServer
{
    public partial class FormSetIp : Form
    {
        public List<string> listIP =new List<string>();
        public FormSetIp(List<string> IPs)
        {
            listIP = IPs;
            InitializeComponent();
            cmdSubmit.Focus();
        }

        public delegate void UpdateHandler(object sender, UpdateEventArgs args);
        public event UpdateHandler EventUpdateHandler;
        public class UpdateEventArgs : EventArgs
        {
            public string IPClient { get; set; }
            public List<string> _listIP { get; set; }
        }

        public void Updates()
        {
            UpdateEventArgs args = new UpdateEventArgs();

            args.IPClient = mtbIP.Text;
            args._listIP = new List<string>(); 
             args._listIP   = listIP;
            EventUpdateHandler.Invoke(this, args);

        }
        private void cmdSubmit_Click(object sender, EventArgs e)
        {
           if(mtbIP.Text != string.Empty)
            {
                if(listIP.Any(ip => ip == mtbIP.Text) !=true)
                {
                    listIP.Where(ip => ip == mtbIP.Text).FirstOrDefault();
                    listIP.Add(mtbIP.Text);
                    Updates();
                    mtbIP.Text = "";
                }
                else
                {
                    MessageBox.Show("Ton tai IP Address moi nhap lai!");
                }


            }
            else
            {
                MessageBox.Show("Ban chua nhap IP may con");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
