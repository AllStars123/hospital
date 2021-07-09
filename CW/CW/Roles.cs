using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CW
{
    public partial class Roles : Form
    {
        public Roles()
        {
            InitializeComponent();
        }

        //Вход в роли главврача
        private void buttonHD_Click(object sender, EventArgs e)
        {
            Form autHD = new HeadDoctor();
            autHD.Show();
        }

        //Вход в роли врача
        private void buttonD_Click(object sender, EventArgs e)
        {
            Form autD = new Doctor();
            autD.Show();
        }

        //Вход в роли аптекаря
        private void buttonP_Click(object sender, EventArgs e)
        {
            Form autP = new Pharmacy();
            autP.Show();
        }

        //Вход в роли пациента
        private void buttonPatient_Click(object sender, EventArgs e)
        {
            Form autPatient = new Patient();
            autPatient.Show();
        }
    }
}
