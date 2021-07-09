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
    public partial class Patient : Form
    {
        private System.Data.OleDb.OleDbDataAdapter vAdapter, pAdapter, rAdapter, statusAdapter, oAdapter, medicamentAdapter, patientAdapter, dAdapter, prAdapter, mAdapter;
        private System.Data.DataSet vSet, pSet, rSet, statusSet, oSet, medicamentSet, patientSet, dSet, prSet, mSet;

        private System.Data.DataTable vTable, pTable, rTable, statusTable, oTable, medicamentTable, patientTable, dTable, prTable, mTable;

        public Patient()
        {
            InitializeComponent();
            cn.Open();

            tabPage2.Enabled = false;
            tabPage3.Enabled = false;
            tabPage4.Enabled = false;
            tabPage5.Enabled = false;

            statusSet = new DataSet();

            String strSQL1 = "SELECT StatusID, name FROM StatusProcedurs";

            statusAdapter = new OleDbDataAdapter(strSQL1, cn);
            statusAdapter.Fill(statusSet, "StatusProcedurs");
            statusTable = statusSet.Tables["StatusProcedurs"];

            cbStatus.ValueMember = "StatusID";
            cbStatus.DisplayMember = "name";
            cbStatus.DataSource = statusTable;

            medicamentSet = new DataSet();

            String strSQL2 = "SELECT MedicamentID, Name FROM Pharmacy";

            medicamentAdapter = new OleDbDataAdapter(strSQL2, cn);
            medicamentAdapter.Fill(medicamentSet, "Pharmacy");
            medicamentTable = medicamentSet.Tables["Pharmacy"];

            cbMedicament.ValueMember = "MedicamentID";
            cbMedicament.DisplayMember = "Name";
            cbMedicament.DataSource = medicamentTable;
        }

        //Вход
        private void bLogIN_Click(object sender, EventArgs e)
        {
            String id = "";
                
            String strSQL = "SELECT PatientID FROM patients WHERE username = " + tbLogin.Text + " AND password = " + tbPassword.Text;
            OleDbCommand command = new OleDbCommand(strSQL, cn);

            OleDbDataReader reader = command.ExecuteReader();


            if (reader.HasRows)
            {
                MessageBox.Show("Вход успешно выполнен!");
                tabPage3.Enabled = true;
                tabPage4.Enabled = true;
                tabPage5.Enabled = true;
                tabControl1.SelectedTab = tabPage3;

                if (reader.Read())
                {
                    id = reader[0].ToString();
                }
                pSet = new DataSet();

                String strSQL1 = "SELECT procedurs.name, procedurs.ProcedureID FROM procedurs, PatientsProcedurs WHERE procedurs.ProcedureID = PatientsProcedurs.ProcedureID AND PatientsProcedurs.PatientID = " + id.ToString();

                pAdapter = new OleDbDataAdapter(strSQL1, cn);
                pAdapter.Fill(pSet, "procedurs, PatientsProcedurs");
                pTable = pSet.Tables["procedurs, PatientsProcedurs"];

                cbProcedure.ValueMember = "ProcedureID";
                cbProcedure.DisplayMember = "name";
                cbProcedure.DataSource = pTable;
            }
            else
                MessageBox.Show("Неправильный логин или пароль!", "");
            reader.Close();

            
        }

        private void bRegister_Click(object sender, EventArgs e)
        {
            tabPage2.Enabled = true;
            tabControl1.SelectedTab = tabPage2;
        }

        //Регистрация
        private void bReg_Click(object sender, EventArgs e)
        {
            String strSQL = "SELECT * FROM patients WHERE phone_number = " + tbPhone.Text;
            OleDbCommand command = new OleDbCommand(strSQL, cn);

            OleDbDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                MessageBox.Show("У вас уже есть учетная запись!");

                tabControl1.SelectedTab = tabPage1;
            }
            else
            {
                String str = "SET IDENTITY_INSERT dbo.patients ON DECLARE @PatientID int = (SELECT MAX(PatientID) + 1 FROM patients)" +
 "INSERT INTO patients(PatientID, FIO, account, phone_number, passport, polis, username, password)" +
 " VALUES(@PatientID, ?, NULL, ?, ?, ?, ?, ?) ";

                OleDbCommand cmdIC = new OleDbCommand(str, cn);

                cmdIC.Parameters.Add("@FIO", OleDbType.VarChar, 255);
                cmdIC.Parameters.Add("@phone_number", OleDbType.VarChar, 15);
                cmdIC.Parameters.Add("@passport", OleDbType.VarChar, 10);
                cmdIC.Parameters.Add("@polis", OleDbType.VarChar, 10);
                cmdIC.Parameters.Add("@username", OleDbType.VarChar, 10);
                cmdIC.Parameters.Add("@password", OleDbType.VarChar, 10);
                cmdIC.Parameters[0].Value = tbFIO.Text;
                cmdIC.Parameters[1].Value = tbPhone.Text;
                cmdIC.Parameters[2].Value = tbPassport.Text;
                cmdIC.Parameters[3].Value = tbPolis.Text;
                cmdIC.Parameters[4].Value = tbLogin.Text;
                cmdIC.Parameters[5].Value = tbPassword.Text;

                try
                {
                    cmdIC.ExecuteNonQuery();

                    MessageBox.Show("Учетная запись создана!");

                    tabControl1.SelectedTab = tabPage1;

                    tbFIO.Text = "";
                    tbPhone.Text = "";
                    tbPassport.Text = "";
                    tbPolis.Text = "";
                    tbLogin.Text = "";
                    tbPassword.Text = "";
                }
                catch (OleDbException exc)
                {
                    MessageBox.Show(exc.ToString());
                }

            }
            reader.Close();
        }

        //Вкладка Медкнижка: показать диагноз и процедуры, установить статус процедуры, оплата процедуры
        private void bShow_Click(object sender, EventArgs e)
        {
            prSet = new DataSet();
            dSet = new DataSet();

            String id = "";

            String strSQL = "SELECT PatientID FROM patients WHERE username = " + tbLogin.Text;

            OleDbCommand command = new OleDbCommand(strSQL, cn);
            OleDbDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                if (reader.Read())
                {
                    id = reader[0].ToString();
                }
                prAdapter = new OleDbDataAdapter("SELECT procedurs.name AS Procedures, price, StatusProcedurs.name AS Status FROM procedurs, PatientsProcedurs, StatusProcedurs WHERE procedurs.ProcedureID=PatientsProcedurs.ProcedureID AND PatientsProcedurs.StatusID=StatusProcedurs.StatusID AND PatientsProcedurs.PatientID = " + id.ToString(), cn);
                prAdapter.Fill(prSet, "procedurs, PatientsProcedurs, StatusProcedurs");
                prTable = prSet.Tables["procedurs, PatientsProcedurs, StatusProcedurs"];
                dgProcedure.SetDataBinding(prSet, "procedurs, PatientsProcedurs, StatusProcedurs");

                dAdapter = new OleDbDataAdapter("SELECT diagnos.name AS Diagnos, StatusDiagnos.name AS Status FROM PatientsDiagnos, diagnos, StatusDiagnos WHERE PatientsDiagnos.DiagnosID=diagnos.DiagnosID AND PatientsDiagnos.StatusID=StatusDiagnos.StatusID AND PatientsDiagnos.PatientID = " + id.ToString(), cn);
                dAdapter.Fill(dSet, "PatientsDiagnos, diagnos, StatusDiagnos");
                dTable = dSet.Tables["PatientsDiagnos, diagnos, StatusDiagnos"];
                dgDiagnos.SetDataBinding(dSet, "PatientsDiagnos, diagnos, StatusDiagnos");
            }
            reader.Close();

        }

        private void bSet_Click(object sender, EventArgs e)
        {
            String strSQL = "UPDATE PatientsProcedurs SET StatusID = " + cbStatus.SelectedValue + " WHERE ProcedureID = " + cbProcedure.SelectedValue;

            OleDbCommand command = new OleDbCommand(strSQL, cn);

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Статус процедуры изменен!");
            }
            catch (OleDbException exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }

        private void bPay_Click(object sender, EventArgs e)
        {

            String id = "", totalPrice = "";

            String strSQL = "SELECT PatientID FROM patients WHERE username = " + tbLogin.Text + " AND password = " + tbPassword.Text;
            OleDbCommand command = new OleDbCommand(strSQL, cn);

            OleDbDataReader reader = command.ExecuteReader();


            if (reader.HasRows)
            {

                if (reader.Read())
                {
                    id = reader[0].ToString();
                }
                reader.Close();
                String strSQL1 = "SELECT SUM(price) FROM procedurs, PatientsProcedurs, patients WHERE procedurs.ProcedureID = PatientsProcedurs.ProcedureID AND patients.PatientID = PatientsProcedurs.PatientID AND PatientsProcedurs.PatientID = " + id.ToString()+
                    " GROUP BY patients.account HAVING account > SUM(price)";

                OleDbCommand command1 = new OleDbCommand(strSQL1, cn);
                OleDbDataReader reader1 = command1.ExecuteReader();

                
                if (reader1.HasRows)
                {
                    if (reader1.Read())
                    {
                        totalPrice = reader1[0].ToString();
                    }

                    String strSQL3 = "UPDATE patients SET account = (account - " + totalPrice.ToString() + ") WHERE PatientID="+ id.ToString();
                        OleDbCommand command3 = new OleDbCommand(strSQL3, cn);

                        try
                        {
                            command3.ExecuteNonQuery();
                            MessageBox.Show("Процедуры оплачены!");
                        }
                        catch (OleDbException exc)
                        {
                            MessageBox.Show(exc.ToString());
                        }
                    }
                    reader1.Close();
                }
        }

        //Вкладка Лекарства: добавление и удаление лекарств в заказ, оплата заказа
        private void bShowMedicaments_Click(object sender, EventArgs e)
        {
            rSet = new DataSet();
            oSet = new DataSet();

            String id = "";

            String strSQL = "SELECT PatientID FROM patients WHERE username = " + tbLogin.Text;

            OleDbCommand command = new OleDbCommand(strSQL, cn);
            OleDbDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                if (reader.Read())
                {
                    id = reader[0].ToString();
                }
                rAdapter = new OleDbDataAdapter("SELECT Pharmacy.Name AS Medicament FROM PatientsMedicaments, Pharmacy WHERE PatientsMedicaments.MedicamentID=Pharmacy.MedicamentID AND PatientsMedicaments.PatientID = " + id.ToString(), cn);
                rAdapter.Fill(rSet, "PatientsMedicaments, Pharmacy");
                rTable = rSet.Tables["PatientsMedicaments, Pharmacy"];
                dgRecipe.SetDataBinding(rSet, "PatientsMedicaments, Pharmacy");

                oAdapter = new OleDbDataAdapter("SELECT Pharmacy.Name, OrderDetails.Quantity, OrderDetails.Price FROM OrderDetails, Orders, Pharmacy WHERE OrderDetails.OrderID=Orders.OrderID AND Pharmacy.MedicamentID=OrderDetails.MedicamentID AND Orders.PatientID = " + id.ToString(), cn);
                oAdapter.Fill(oSet, "OrderDetails, Orders, Pharmacy");
                oTable = oSet.Tables["OrderDetails, Orders, Pharmacy"];
                dgOrder.SetDataBinding(oSet, "OrderDetails, Orders, Pharmacy");
            }
            reader.Close();
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            String strSQL = "SET IDENTITY_INSERT dbo.OrderDetails ON DECLARE @OrderDetailID int = (SELECT MAX(OrderDetailID) + 1 FROM OrderDetails)" +
                "DECLARE @OrderID int = (SELECT OrderID FROM Orders, patients WHERE Orders.PatientID=patients.PatientID AND username = " + tbLogin.Text +")"+
                "DECLARE @Name varchar(15) = (SELECT Name FROM Pharmacy WHERE MedicamentID="+cbMedicament.SelectedValue+")"+
                "DECLARE @Price int = (SELECT Price FROM Pharmacy WHERE MedicamentID=" + cbMedicament.SelectedValue +")"+
"INSERT INTO OrderDetails(OrderDetailID, OrderID, MedicamentID, Name, Quantity, Price)" +
" VALUES(@OrderDetailID, @OrderID, ?, @Name, ?, @Price) ";

            OleDbCommand cmdIC = new OleDbCommand(strSQL, cn);

            cmdIC.Parameters.Add("@MedicamentID", OleDbType.Integer);
            cmdIC.Parameters.Add("@Quantity", OleDbType.Integer);
            cmdIC.Parameters[0].Value = cbMedicament.SelectedValue;
            cmdIC.Parameters[1].Value = tbQuantity.Text;
            try
            {
                cmdIC.ExecuteNonQuery();

                MessageBox.Show("Препарат успешно добавлен!");

                tbQuantity.Text = "";
            }
            catch (OleDbException exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }


        private void bDelete_Click(object sender, EventArgs e)
        {
            String strSQL = "DELETE OrderDetails WHERE MedicamentID =" + cbMedicament.SelectedValue;

            OleDbCommand command = new OleDbCommand(strSQL, cn);

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Препарат успешно удален!");
            }
            catch (OleDbException exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }

        private void bPayOrder_Click(object sender, EventArgs e)
        {
            String id = "", totalPrice = "";

            String strSQL = "SELECT PatientID FROM patients WHERE username = " + tbLogin.Text + " AND password = " + tbPassword.Text;
            OleDbCommand command = new OleDbCommand(strSQL, cn);

            OleDbDataReader reader = command.ExecuteReader();


            if (reader.HasRows)
            {

                if (reader.Read())
                {
                    id = reader[0].ToString();
                }
                reader.Close();
                String strSQL1 = "SELECT SUM(Pharmacy.Price) FROM Orders, OrderDetails, Pharmacy, patients WHERE Pharmacy.MedicamentID = OrderDetails.MedicamentID AND Orders.PatientID=patients.PatientID AND Orders.PatientID = " + id.ToString() +
                    " GROUP BY patients.account HAVING account > SUM(Pharmacy.Price)";

                OleDbCommand command1 = new OleDbCommand(strSQL1, cn);
                OleDbDataReader reader1 = command1.ExecuteReader();


                if (reader1.HasRows)
                {
                    if (reader1.Read())
                    {
                        totalPrice = reader1[0].ToString();
                    }

                    String strSQL3 = "UPDATE patients SET account = (account - " + totalPrice.ToString() + ") WHERE PatientID=" + id.ToString();
                    OleDbCommand command3 = new OleDbCommand(strSQL3, cn);

                    try
                    {
                        command3.ExecuteNonQuery();
                        MessageBox.Show("Лекарства оплачены!");
                    }
                    catch (OleDbException exc)
                    {
                        MessageBox.Show(exc.ToString());
                    }
                }
                reader1.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String balans = "";

            String strSQL = "SELECT account FROM patients WHERE username = " + tbLogin.Text;

            OleDbCommand command = new OleDbCommand(strSQL, cn);
            OleDbDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                balans = reader[0].ToString();
                tbBalans.Text = balans.ToString();
            }
            reader.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {

            String strSQL = "UPDATE patients SET account = ( account +"+tbAddBalans.Text+") WHERE username = " + tbLogin.Text;

            OleDbCommand command = new OleDbCommand(strSQL, cn);
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Баланс пополнен!");
            }
            catch (OleDbException exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }
    }
}
