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
    public partial class Pharmacy : Form
    {
        private System.Data.OleDb.OleDbDataAdapter pAdapter, iAdapter, oAdapter, odAdapter;
        private System.Data.DataSet pSet, iSet, oSet, odSet;
        private System.Data.DataTable pTable, iTable, oTable, odTable;

        public Pharmacy()
        {
            InitializeComponent();
            cn.Open();

            tabPage2.Enabled = false;
            tabPage3.Enabled = false;

            iSet = new DataSet();

            String strSQL = "SELECT MedicamentID, Name FROM Pharmacy";

            iAdapter = new OleDbDataAdapter(strSQL, cn);
            iAdapter.Fill(iSet, "Pharmacy");
            iTable = iSet.Tables["Pharmacy"];

            cbName.ValueMember = "MedicamentID";
            cbName.DisplayMember = "Name";
            cbName.DataSource = iTable;

            odSet = new DataSet();

            String strSQL1 = "SELECT OrderDetailID FROM OrderDetails";

            odAdapter = new OleDbDataAdapter(strSQL1, cn);
            odAdapter.Fill(odSet, "OrderDetails");
            odTable = odSet.Tables["OrderDetails"];

            cbOrder.ValueMember = "OrderDetailID";
            cbOrder.DisplayMember = "OrderDetailID";
            cbOrder.DataSource = odTable;
        }

        //Вход
        private void bLogIN_Click(object sender, EventArgs e)
        {
            String strSQL = "SELECT * FROM Doctors WHERE username = " + tbLogin.Text + " AND password = " + tbPassword.Text + "AND PositionID=3";
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

        //Вкладка Аптека: добавление и удаление препарата, просмотр препаратов в наличии
        private void bInStock_Click(object sender, EventArgs e)
        {
            pSet = new DataSet();

            String strSQL = "SELECT * FROM Pharmacy";

            pAdapter = new OleDbDataAdapter(strSQL, cn);
            pAdapter.Fill(pSet, "Pharmacy");
            pTable = pSet.Tables["Pharmacy"];
            dgPharmacy.SetDataBinding(pSet, "Pharmacy");

        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            String strSQL = "SET IDENTITY_INSERT dbo.Pharmacy ON DECLARE @MedicamentID int = (SELECT MAX(MedicamentID) + 1 FROM Pharmacy)" +
"INSERT INTO Pharmacy(MedicamentID, Name, Price, Quantity)" +
" VALUES(@MedicamentID, ?, ?, ?) ";

            OleDbCommand cmdIC = new OleDbCommand(strSQL, cn);

            cmdIC.Parameters.Add("@Name", OleDbType.VarChar, 15);
            cmdIC.Parameters.Add("@Price", OleDbType.Integer);
            cmdIC.Parameters.Add("@Quantity", OleDbType.Integer);
            cmdIC.Parameters[0].Value = tbName.Text;
            cmdIC.Parameters[1].Value = tbPrice.Text;
            cmdIC.Parameters[2].Value = tbQuantity.Text;
            try
            {
                cmdIC.ExecuteNonQuery();

                MessageBox.Show("Препарат успешно добавлен!");

                tbName.Text = "";
                tbPrice.Text = "";
                tbQuantity.Text = "";
            }
            catch (OleDbException exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            String strSQL = "DELETE Pharmacy WHERE MedicamentID =" + cbName.SelectedValue;

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

        //Вкладка Заказы: выдача товара, просмотр всех позиций заказов
        private void bOrders_Click(object sender, EventArgs e)
        {
            oSet = new DataSet();

            String strSQL = "SELECT OrderDetailId AS ID, Name, Quantity FROM OrderDetails";

            oAdapter = new OleDbDataAdapter(strSQL, cn);
            oAdapter.Fill(oSet, "OrderDetails");
            oTable = oSet.Tables["OrderDetails"];
            dgOrders.SetDataBinding(oSet, "OrderDetails");
        }

        private void bSupply_Click(object sender, EventArgs e)
        {
            String nameID = "", quantity = "";

            String strSQL = "SELECT MedicamentID, Quantity FROM OrderDetails WHERE OrderDetailID = " + cbOrder.SelectedValue;

            OleDbCommand command = new OleDbCommand(strSQL, cn);
            OleDbDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                nameID = reader[0].ToString();
                quantity = reader[1].ToString();

                reader.Close();

                String strSQL1 = "SELECT MedicamentID FROM Pharmacy WHERE MedicamentID = " + nameID.ToString() +
                " AND Quantity > " + quantity.ToString();

                OleDbCommand command1 = new OleDbCommand(strSQL1, cn);
                OleDbDataReader reader1 = command1.ExecuteReader();

                if (reader1.HasRows)
                {
                    String strSQL2 = "UPDATE Pharmacy SET Quantity = (Quantity -" +
                    quantity.ToString() + ") WHERE MedicamentID = " + nameID.ToString();

                    OleDbCommand command2 = new OleDbCommand(strSQL2, cn);

                    try
                    {
                        command2.ExecuteNonQuery();

                        String strSQL3 = "SET IDENTITY_INSERT dbo.OrderDetails ON DELETE OrderDetails WHERE OrderDetailID = " + cbOrder.SelectedValue;

                        OleDbCommand command3 = new OleDbCommand(strSQL3, cn);

                        try
                        {
                            command3.ExecuteNonQuery();
                            MessageBox.Show("Товар успешно выдан!");
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
                reader1.Close();
            }

        }
    }
}
