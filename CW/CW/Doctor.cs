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
    public partial class Doctor : Form
    {
        private System.Data.OleDb.OleDbDataAdapter vAdapter, pAdapter, diagnosAdapter, statusAdapter, procedureAdapter, medicamentAdapter, patientAdapter, dAdapter, prAdapter, mAdapter;
        private System.Data.DataSet vSet, pSet, diagnosSet, statusSet, procedureSet, medicamentSet, patientSet, dSet, prSet, mSet;
        private System.Data.DataTable vTable, pTable, diagnosTable, statusTable, procedureTable, medicamentTable, patientTable, dTable, prTable, mTable;

        public Doctor()
        {
            InitializeComponent();
            cn.Open();

            tabPage2.Enabled = false;
            tabPage3.Enabled = false;

            diagnosSet = new DataSet();

            String strSQL = "SELECT DiagnosID, name FROM diagnos";

            diagnosAdapter = new OleDbDataAdapter(strSQL, cn);
            diagnosAdapter.Fill(diagnosSet, "diagnos");
            diagnosTable = diagnosSet.Tables["diagnos"];

            cbDiagnos.ValueMember = "DiagnosID";
            cbDiagnos.DisplayMember = "name";
            cbDiagnos.DataSource = diagnosTable;

            statusSet = new DataSet();

            String strSQL1 = "SELECT StatusID, name FROM StatusDiagnos";

            statusAdapter = new OleDbDataAdapter(strSQL1, cn);
            statusAdapter.Fill(statusSet, "StatusDiagnos");
            statusTable = statusSet.Tables["StatusDiagnos"];

            cbStatus.ValueMember = "StatusID";
            cbStatus.DisplayMember = "name";
            cbStatus.DataSource = statusTable;

            procedureSet = new DataSet();

            String strSQL2 = "SELECT ProcedureID, name FROM procedurs";

            procedureAdapter = new OleDbDataAdapter(strSQL2, cn);
            procedureAdapter.Fill(procedureSet, "procedurs");
            procedureTable = procedureSet.Tables["procedurs"];

            cbProcedure.ValueMember = "ProcedureID";
            cbProcedure.DisplayMember = "name";
            cbProcedure.DataSource = procedureTable;

            medicamentSet = new DataSet();

            String strSQL3 = "SELECT MedicamentID, Name FROM Pharmacy";

            medicamentAdapter = new OleDbDataAdapter(strSQL3, cn);
            medicamentAdapter.Fill(medicamentSet, "Pharmacy");
            medicamentTable = medicamentSet.Tables["Pharmacy"];

            cbMedicament.ValueMember = "MedicamentID";
            cbMedicament.DisplayMember = "Name";
            cbMedicament.DataSource = medicamentTable;
        }

        //Вход
        private void bLogIN_Click(object sender, EventArgs e)
        {
            String strSQL = "SELECT * FROM Doctors WHERE username = " + tbLogin.Text + " AND password = " + tbPassword.Text + "AND PositionID = 1";
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

            patientSet = new DataSet();

            String strSQL3 = "SELECT patients.PatientID, patients.FIO FROM patients, vizit, Doctors WHERE patients.PatientID=vizit.PatientID" +
                " AND vizit.DoctorID=Doctors.DoctorID AND Doctors.username = " + tbLogin.Text;

            patientAdapter = new OleDbDataAdapter(strSQL3, cn);
            patientAdapter.Fill(patientSet, "patients");
            patientTable = patientSet.Tables["patients"];

            cbPatient.ValueMember = "PatientID";
            cbPatient.DisplayMember = "FIO";
            cbPatient.DataSource = patientTable;

        }

        //Вкладка Приемы:просмотр приемов у врача, просмотр информации о пациентах
        private void bVizits_Click(object sender, EventArgs e)
        {
            vSet = new DataSet();

            String id = "";

            String strSQL = "SELECT DoctorID FROM Doctors WHERE Doctors.username = " + tbLogin.Text;

            OleDbCommand command = new OleDbCommand(strSQL, cn);
            OleDbDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                if (reader.Read())
                {
                    id = reader[0].ToString();
                }
                vAdapter = new OleDbDataAdapter("SELECT FIO, Date FROM vizit, patients WHERE patients.PatientID=vizit.PatientID AND DoctorID=" + id.ToString(), cn);
                vAdapter.Fill(vSet, "patients, vizit");
                vTable = vSet.Tables["patients, vizit"];
                dgVizits.SetDataBinding(vSet, "patients, vizit");
            }
            reader.Close();
        }

        private void bPatients_Click(object sender, EventArgs e)
        {
            pSet = new DataSet();

            String id = "";

            String strSQL = "SELECT DoctorID FROM Doctors WHERE Doctors.username = " + tbLogin.Text;

            OleDbCommand command = new OleDbCommand(strSQL, cn);
            OleDbDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                if (reader.Read())
                {
                    id = reader[0].ToString();
                }
                pAdapter = new OleDbDataAdapter("SELECT FIO, phone_number, passport, polis FROM patients, vizit WHERE patients.PatientID=vizit.PatientID AND DoctorID=" + id.ToString(), cn);
                pAdapter.Fill(pSet, "patients, vizit");
                pTable = pSet.Tables["patients, vizit"];
                dgPatients.SetDataBinding(pSet, "patients, vizit");
            }
            reader.Close();
        }

        //Вкладка медкнижки:назначение диагноза и его статуса, процедур, лекарств и просмотр медкнижки
        private void bSee_Click(object sender, EventArgs e)
        {
            prSet = new DataSet();

            prAdapter = new OleDbDataAdapter("SELECT procedurs.name AS Procedures FROM procedurs, PatientsProcedurs WHERE procedurs.ProcedureID=PatientsProcedurs.ProcedureID AND PatientsProcedurs.PatientID = "+cbPatient.SelectedValue, cn);
            prAdapter.Fill(prSet, "procedurs, PatientsProcedurs");
            prTable = prSet.Tables["procedurs, PatientsProcedurs"];
            dgProcedure.SetDataBinding(prSet, "procedurs, PatientsProcedurs");

            dSet = new DataSet();

            dAdapter = new OleDbDataAdapter("SELECT diagnos.name AS Diagnos, StatusDiagnos.name AS Status FROM PatientsDiagnos, diagnos, StatusDiagnos WHERE PatientsDiagnos.DiagnosID=diagnos.DiagnosID AND PatientsDiagnos.StatusID=StatusDiagnos.StatusID AND PatientsDiagnos.PatientID = " + cbPatient.SelectedValue, cn);
            dAdapter.Fill(dSet, "PatientsDiagnos, diagnos, StatusDiagnos");
            dTable = dSet.Tables["PatientsDiagnos, diagnos, StatusDiagnos"];
            dgDiagnos.SetDataBinding(dSet, "PatientsDiagnos, diagnos, StatusDiagnos");

            mSet = new DataSet();

            mAdapter = new OleDbDataAdapter("SELECT Pharmacy.Name AS Medicament FROM PatientsMedicaments, Pharmacy WHERE PatientsMedicaments.MedicamentID=Pharmacy.MedicamentID AND PatientsMedicaments.PatientID = " + cbPatient.SelectedValue, cn);
            mAdapter.Fill(mSet, "PatientsMedicaments, Pharmacy");
            mTable = mSet.Tables["PatientsMedicaments, Pharmacy"];
            dgMedicament.SetDataBinding(mSet, "PatientsMedicaments, Pharmacy");
        }

        private void bDiagnos_Click(object sender, EventArgs e)
        {
            String id = "";

            String strSQL = "SELECT VisitID, PatientID FROM vizit WHERE PatientID = " + cbPatient.SelectedValue;

            OleDbCommand command = new OleDbCommand(strSQL, cn);
            OleDbDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                if (reader.Read())
                {
                    id = reader[0].ToString();
                }
                String strSQL1 = "DECLARE @ID int = (SELECT MAX(ID) + 1 FROM PatientsDiagnos)" +
"INSERT INTO PatientsDiagnos(ID, PatientID, DiagnosID, StatusID, active_from, active_to, VisitID)" +
" VALUES(@ID, ?, ?, ?, Null, Null, ?) ";

                OleDbCommand cmdIC = new OleDbCommand(strSQL1, cn);

                cmdIC.Parameters.Add("@PatientID", OleDbType.Integer);
                cmdIC.Parameters.Add("@DiagnosID", OleDbType.Integer);
                cmdIC.Parameters.Add("@StatusID", OleDbType.Integer);
                cmdIC.Parameters.Add("@VisitID", OleDbType.Integer);
                cmdIC.Parameters[0].Value = cbPatient.SelectedValue;
                cmdIC.Parameters[1].Value = cbDiagnos.SelectedValue;
                cmdIC.Parameters[2].Value = cbStatus.SelectedValue;
                cmdIC.Parameters[3].Value = id.ToString();
                try
                {
                    cmdIC.ExecuteNonQuery();

                    MessageBox.Show("Диагноз поставлен!");
                }
                catch (OleDbException exc)
                {
                    MessageBox.Show(exc.ToString());
                }
            }
            else
            {
                String strSQL2 = "SET IDENTITY_INSERT dbo.vizit ON DECLARE @VisitID int = (SELECT MAX(VisitID) + 1 FROM vizit)" +
                "DECLARE @DoctorID int = (SELECT DoctorID FROM Doctors WHERE username = " + tbLogin.Text + ") " +
                "DECLARE @PatientID int = (SELECT PatientID FROM Patients WHERE PatientID = " + cbPatient.SelectedValue + ") " +
                "INSERT INTO vizit(VisitID, PatientID, DoctorID, Date)" +
                " VALUES(@VisitID, @PatientID, @DoctorID, Null)";

                OleDbCommand command2 = new OleDbCommand(strSQL2, cn);

                try
                {
                    command2.ExecuteNonQuery();

                    String strSQL3 = "DECLARE @ID int = (SELECT MAX(ID) + 1 FROM PatientsDiagnos)" +
                        "DECLARE @VisitID int = (SELECT MAX(VisitID) FROM vizit)" +
"INSERT INTO PatientsDiagnos(ID, PatientID, DiagnosID, StatusID, active_from, active_to, VisitID)" +
" VALUES(@ID, ?, ?, ?, Null, Null, @VisitID) ";

                    OleDbCommand command3 = new OleDbCommand(strSQL3, cn);

                    command3.Parameters.Add("@PatientID", OleDbType.Integer);
                    command3.Parameters.Add("@DiagnosID", OleDbType.Integer);
                    command3.Parameters.Add("@StatusID", OleDbType.Integer);
                    command3.Parameters[0].Value = cbPatient.SelectedValue;
                    command3.Parameters[1].Value = cbDiagnos.SelectedValue;
                    command3.Parameters[2].Value = cbStatus.SelectedValue;

                    try
                    {
                        command3.ExecuteNonQuery();

                        MessageBox.Show("Диагноз поставлен!");
                    }
                    catch (OleDbException exc)
                    {
                        MessageBox.Show(exc.ToString());
                    }
                }
                catch (OleDbException exc)
                {
                    MessageBox.Show(exc.ToString());
                }
            }
            reader.Close();
        }

        private void bProcedure_Click(object sender, EventArgs e)
        {
            String id = "";

            String strSQL = "SELECT VisitID, PatientID FROM vizit WHERE PatientID = " + cbPatient.SelectedValue;

            OleDbCommand command = new OleDbCommand(strSQL, cn);
            OleDbDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                if (reader.Read())
                {
                    id = reader[0].ToString();
                }
                String strSQL1 = "SET IDENTITY_INSERT dbo.PatientsProcedurs ON DECLARE @ID int = (SELECT MAX(ID) + 1 FROM PatientsProcedurs)" +
"INSERT INTO PatientsProcedurs(ID, PatientID, ProcedureID, StatusID, VisitID)" +
" VALUES(@ID, ?, ?, 2, ?) ";

                OleDbCommand cmdIC = new OleDbCommand(strSQL1, cn);

                cmdIC.Parameters.Add("@PatientID", OleDbType.Integer);
                cmdIC.Parameters.Add("@ProcedureID", OleDbType.Integer);
                cmdIC.Parameters.Add("@VisitID", OleDbType.Integer);
                cmdIC.Parameters[0].Value = cbPatient.SelectedValue;
                cmdIC.Parameters[1].Value = cbProcedure.SelectedValue;
                cmdIC.Parameters[2].Value = id.ToString();
                try
                {
                    cmdIC.ExecuteNonQuery();

                    MessageBox.Show("Процедура назначена!");
                }
                catch (OleDbException exc)
                {
                    MessageBox.Show(exc.ToString());
                }
            }
            else
            {
                String strSQL2 = "SET IDENTITY_INSERT dbo.vizit ON DECLARE @VisitID int = (SELECT MAX(VisitID) + 1 FROM vizit)" +
                "DECLARE @DoctorID int = (SELECT DoctorID FROM Doctors WHERE username = " + tbLogin.Text + ") " +
                "DECLARE @PatientID int = (SELECT PatientID FROM Patients WHERE PatientID = " + cbPatient.SelectedValue + ") " +
                "INSERT INTO vizit(VisitID, PatientID, DoctorID, Date)" +
                " VALUES(@VisitID, @PatientID, @DoctorID, Null)";

                OleDbCommand command2 = new OleDbCommand(strSQL2, cn);

                try
                {
                    command2.ExecuteNonQuery();

                    String strSQL3 = "SET IDENTITY_INSERT dbo.PatientsProcedurs ON DECLARE @ID int = (SELECT MAX(ID) + 1 FROM PatientsProcedurs)" +
                        "DECLARE @VisitID int = (SELECT MAX(VisitID) FROM vizit)" +
"INSERT INTO PatientsProcedurs(ID, PatientID, ProcedureID, StatusID, VisitID)" +
" VALUES(@ID, ?, ?, 2, @VisitID) ";

                    OleDbCommand command3 = new OleDbCommand(strSQL3, cn);

                    command3.Parameters.Add("@PatientID", OleDbType.Integer);
                    command3.Parameters.Add("@ProcedureID", OleDbType.Integer);
                    command3.Parameters[0].Value = cbPatient.SelectedValue;
                    command3.Parameters[1].Value = cbProcedure.SelectedValue;

                    try
                    {
                        command3.ExecuteNonQuery();

                        MessageBox.Show("Процедура назначена!");
                    }
                    catch (OleDbException exc)
                    {
                        MessageBox.Show(exc.ToString());
                    }
                }
                catch (OleDbException exc)
                {
                    MessageBox.Show(exc.ToString());
                }
            }
            reader.Close();
        }

        private void bMedicament_Click(object sender, EventArgs e)
        {
            String id = "";

            String strSQL = "SELECT VisitID, PatientID FROM vizit WHERE PatientID = " + cbPatient.SelectedValue;

            OleDbCommand command = new OleDbCommand(strSQL, cn);
            OleDbDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                if (reader.Read())
                {
                    id = reader[0].ToString();
                }
                String strSQL1 = "SET IDENTITY_INSERT dbo.PatientsMedicaments ON DECLARE @ID int = (SELECT MAX(ID) + 1 FROM PatientsMedicaments)" +
"INSERT INTO PatientsMedicaments(ID, PatientID, MedicamentID, VisitID)" +
" VALUES(@ID, ?, ?, ?) ";

                OleDbCommand cmdIC = new OleDbCommand(strSQL1, cn);

                cmdIC.Parameters.Add("@PatientID", OleDbType.Integer);
                cmdIC.Parameters.Add("@MedicamentID", OleDbType.Integer);
                cmdIC.Parameters.Add("@VisitID", OleDbType.Integer);
                cmdIC.Parameters[0].Value = cbPatient.SelectedValue;
                cmdIC.Parameters[1].Value = cbMedicament.SelectedValue;
                cmdIC.Parameters[2].Value = id.ToString();
                try
                {
                    cmdIC.ExecuteNonQuery();

                    MessageBox.Show("Лекарство выписано!");
                }
                catch (OleDbException exc)
                {
                    MessageBox.Show(exc.ToString());
                }
            }
            else
            {
                String strSQL2 = "SET IDENTITY_INSERT dbo.vizit ON DECLARE @VisitID int = (SELECT MAX(VisitID) + 1 FROM vizit)" +
                "DECLARE @DoctorID int = (SELECT DoctorID FROM Doctors WHERE username = " + tbLogin.Text + ") " +
                "DECLARE @PatientID int = (SELECT PatientID FROM Patients WHERE PatientID = " + cbPatient.SelectedValue + ") " +
                "INSERT INTO vizit(VisitID, PatientID, DoctorID, Date)" +
                " VALUES(@VisitID, @PatientID, @DoctorID, Null)";

                OleDbCommand command2 = new OleDbCommand(strSQL2, cn);

                try
                {
                    command2.ExecuteNonQuery();

                    String strSQL3 = "SET IDENTITY_INSERT dbo.PatientsMedicaments ON DECLARE @ID int = (SELECT MAX(ID) + 1 FROM PatientsMedicaments)" +
                        "DECLARE @VisitID int = (SELECT MAX(VisitID) FROM vizit)" +
"INSERT INTO PatientsMedicaments(ID, PatientID, MedicamentID, VisitID)" +
" VALUES(@ID, ?, ?, @VisitID) ";

                    OleDbCommand command3 = new OleDbCommand(strSQL3, cn);

                    command3.Parameters.Add("@PatientID", OleDbType.Integer);
                    command3.Parameters.Add("@MedicamentID", OleDbType.Integer);
                    command3.Parameters[0].Value = cbPatient.SelectedValue;
                    command3.Parameters[1].Value = cbMedicament.SelectedValue;

                    try
                    {
                        command3.ExecuteNonQuery();

                        MessageBox.Show("Лекарство выписано!");
                    }
                    catch (OleDbException exc)
                    {
                        MessageBox.Show(exc.ToString());
                    }
                }
                catch (OleDbException exc)
                {
                    MessageBox.Show(exc.ToString());
                }
            }
            reader.Close();
        }
    }
}
