using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormServer
{
    public partial class PC : UserControl
    {
        public PC()
        {
            InitializeComponent();
        }

        public string clientIP { get; set; }

        private string _name;
        private string _MSSV;
      
        private Color _color;
        public string pcName { get { return _name; } set { _name = value; lbNamePC.Text = "PC " + value; } }

        public string MSSV { get { return _MSSV; } set { _MSSV = value; lbMSSV.Text = value; } }
        public Color ColorUser
        {
            get { return _color; }
            set
            {
                _color = value;  pnUser.BackColor = _color;
            }
        }

      public  void DisablePC()
        {
            this.pnUser.Enabled = false;
        }

    }
}
