using eManagerSystem.Application;
using eManagerSystem.Application.Catalog.Server;
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
    public partial class Form2 : Form
    {
        IServerService _server;
        IEnumerable<Grade> _grades;
        List<Students> _students;
        public Form2(IEnumerable<Grade> grades, IServerService server)
        {
            _grades = grades;
            _server = server;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            _students = new List<Students>();
        }

        public delegate void UpdateHandler(object sender, UpdateEventArgs args);
        public event UpdateHandler EventUpdateHandler;
        public class UpdateEventArgs : EventArgs
        {
           public  List<Students> studentsDelegate { get; set; }
            
        }


        private void cbGrade_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if (cbGrade.SelectedItem != null)
            {
                string IdGrade = cbGrade.SelectedValue.ToString();
               if(IdGrade != "eManagerSystem.Application.Grade")
                {
                    _students = _server.ReadAll(int.Parse(IdGrade));
                    dataGridView1.DataSource = _students;
                  
                }
                


            }
        }

        public void Updates()
        {
            UpdateEventArgs args = new UpdateEventArgs();
            if(_students.Count > 0)
            {
                args.studentsDelegate = _students;
                EventUpdateHandler.Invoke(this, args);
            }
           
        }

        private void cbGrade_Click(object sender, EventArgs e)
        {
            cbGrade.DataSource = _grades;
            cbGrade.DisplayMember = "GradeName";
            cbGrade.ValueMember = "GradeId";

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Updates();
            this.Hide();
        }
    }
}
