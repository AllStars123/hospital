using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace CW
{
    public partial class HeadDoctor : Form
    {
        private System.Data.OleDb.OleDbDataAdapter dAdapter, iAdapter, piAdapter, pAdapter;
        private System.Data.DataSet dSet, iSet, piSet, pSet;
        private System.Data.DataTable dTable, iTable, piTable, pTable;

        public HeadDoctor()
        {
            InitializeComponent();
            cn.Open();

            tabPage2.Enabled = false;
            tabPage3.Enabled = false;

            iSet = new DataSet();

            String strSQL = "SELECT DoctorID, FIO FROM Doctors WHERE PositionID = 1";

            iAdapter = new OleDbDataAdapter(strSQL, cn);
            iAdapter.Fill(iSet, "Doctors");
            iTable = iSet.Tables["Doctors"];

            cbFIO.ValueMember = "DoctorID";
            cbFIO.DisplayMember = "FIO";
            cbFIO.DataSource = iTable;

            piSet = new DataSet();

            String strSQL1 = "SELECT ProcedureID, name FROM Procedurs";

            piAdapter = new OleDbDataAdapter(strSQL1, cn);
            piAdapter.Fill(piSet, "Procedurs");
            piTable = piSet.Tables["Procedurs"];

            cbProcedurs.ValueMember = "ProcedureID";
            cbProcedurs.DisplayMember = "name";
            cbProcedurs.DataSource = piTable;
        }

        //Вход
        private void bLogIN_Click(object sender, EventArgs e)
        {
            String strSQL = "SELECT * FROM Doctors WHERE username = " + tbLogin.Text + " AND password = " + tbPassword.Text + "AND PositionID=2";
            OleDbCommand command = new OleDbCommand(strSQL, cn);

            OleDbDataReader reader = command.ExecuteReader();


            if (reader.HasRows)
            {
                MessageBox.Show("Вход успешно выполнен!");
                tabPage2.Enabled = true;
                tabPage3.Enabled = true;
                tabControl1.SelectedTab = tabPage2;
            }
            else
                MessageBox.Show("Неправильный логин или пароль!", "");
            reader.Close();
        }

        //Вкладка Врачи: нанять, уволить врачей и посмотреть список всех врачей
        private void bDoctors_Click(object sender, EventArgs e)
        {
            dSet = new DataSet();

            String strSQL = "SELECT * FROM Doctors WHERE PositionID = 1";

            dAdapter = new OleDbDataAdapter(strSQL, cn);
            dAdapter.Fill(dSet, "Doctors");
            dTable = dSet.Tables["Doctors"];
            dgDoctors.SetDataBinding(dSet, "Doctors");
        }

        private void bHire_Click(object sender, EventArgs e)
        {
            String strSQL = "SET IDENTITY_INSERT dbo.Doctors ON DECLARE @DoctorID int = (SELECT MAX(DoctorID) + 1 FROM Doctors)" +
"INSERT INTO Doctors(DoctorID, FIO, PositionID, Phone, Password, Username)" +
" VALUES(@DoctorID, ?, 1, ?, ?, ?) ";

            OleDbCommand cmdIC = new OleDbCommand(strSQL, cn);

            cmdIC.Parameters.Add("@FIO", OleDbType.VarChar, 50);
            cmdIC.Parameters.Add("@Phone", OleDbType.Integer);
            cmdIC.Parameters.Add("@Password", OleDbType.VarChar, 10);
            cmdIC.Parameters.Add("@Username", OleDbType.VarChar, 10);
            cmdIC.Parameters[0].Value = tbFIO.Text;
            cmdIC.Parameters[1].Value = tbPhone.Text;
            cmdIC.Parameters[2].Value = tbPass.Text;
            cmdIC.Parameters[3].Value = tbLog.Text;

            try
            {
                cmdIC.ExecuteNonQuery();

                MessageBox.Show("Врач успешно нанят!");

                tbFIO.Text = "";
                tbPhone.Text = "";
                tbPass.Text = "";
                tbLog.Text = "";
            }
            catch (OleDbException exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }

        private void bFire_Click(object sender, EventArgs e)
        {
            String strSQL = "DELETE Doctors WHERE DoctorID=" + cbFIO.SelectedValue;

            OleDbCommand command = new OleDbCommand(strSQL, cn);

            try
            {
                command.ExecuteNonQuery();

                MessageBox.Show("Врач успешно уволен!");

            }
            catch (OleDbException exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }

        //Вкладка Процедуры: добавить и удалить процедуру, посмотреть все процедуры
        private void bProcedurs_Click(object sender, EventArgs e)
        {
            pSet = new DataSet();

            String strSQL = "SELECT * FROM Procedurs";

            pAdapter = new OleDbDataAdapter(strSQL, cn);
            pAdapter.Fill(pSet, "Procedurs");
            pTable = pSet.Tables["Procedurs"];
            dgProcedurs.SetDataBinding(pSet, "Procedurs");
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            String strSQL = "SET IDENTITY_INSERT dbo.Procedurs ON DECLARE @ProcedureID int = (SELECT MAX(ProcedureID) + 1 FROM Procedurs)" +
"INSERT INTO Procedurs(ProcedureID, name, price)" +
" VALUES(@ProcedureID, ?, ?) ";

            OleDbCommand cmdIC = new OleDbCommand(strSQL, cn);

            cmdIC.Parameters.Add("@name", OleDbType.VarChar, 50);
            cmdIC.Parameters.Add("@price", OleDbType.Decimal);
            cmdIC.Parameters[0].Value = tbName.Text;
            cmdIC.Parameters[1].Value = tbPrice.Text;

            try
            {
                cmdIC.ExecuteNonQuery();

                MessageBox.Show("Процедура успешно добавлена!");

                tbFIO.Text = "";
                tbPhone.Text = "";
            }
            catch (OleDbException exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            String strSQL = "DELETE Procedurs WHERE ProcedureID=" + cbProcedurs.SelectedValue;

            OleDbCommand command = new OleDbCommand(strSQL, cn);

            try
            {
                command.ExecuteNonQuery();

                MessageBox.Show("Процедура успешно удалена!");

            }
            catch (OleDbException exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }
    }
}
