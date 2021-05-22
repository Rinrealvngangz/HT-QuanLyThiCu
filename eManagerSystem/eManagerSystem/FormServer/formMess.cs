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
    public partial class formMess : Form
    {
        public formMess()
        {
            InitializeComponent();
        }

        public delegate void UpdateHandler(object sender, UpdateEventArgs args);
        public event UpdateHandler EventUpdateHandler;
        public class UpdateEventArgs : EventArgs
        {
            public string mess { get; set; }

        }
        public void Updates()
        {
            UpdateEventArgs args = new UpdateEventArgs();
            if (tbMess.Text !=string.Empty)
            {
                args.mess = tbMess.Text;
                EventUpdateHandler.Invoke(this, args);
            }
            else{
                MessageBox.Show("ban chua nhap noi dung");
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Updates();
        }
    }
}
