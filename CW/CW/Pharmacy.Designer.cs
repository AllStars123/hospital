namespace CW
{
    partial class Pharmacy
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.bLogIN = new System.Windows.Forms.Button();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.cbName = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgPharmacy = new System.Windows.Forms.DataGrid();
            this.bInStock = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.bSupply = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.cbOrder = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dgOrders = new System.Windows.Forms.DataGrid();
            this.cn = new System.Data.OleDb.OleDbConnection();
            this.bOrders = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPharmacy)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(797, 438);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.bLogIN);
            this.tabPage1.Controls.Add(this.tbPassword);
            this.tabPage1.Controls.Add(this.tbLogin);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(789, 412);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Вход";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // bLogIN
            // 
            this.bLogIN.Location = new System.Drawing.Point(321, 290);
            this.bLogIN.Name = "bLogIN";
            this.bLogIN.Size = new System.Drawing.Size(136, 35);
            this.bLogIN.TabIndex = 18;
            this.bLogIN.Text = "Войти";
            this.bLogIN.UseVisualStyleBackColor = true;
            this.bLogIN.Click += new System.EventHandler(this.bLogIN_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(321, 207);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(136, 20);
            this.tbPassword.TabIndex = 17;
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(321, 168);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(136, 20);
            this.tbLogin.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(261, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Пароль";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(261, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Логин";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(37, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 26);
            this.label1.TabIndex = 13;
            this.label1.Text = "Введите данные для авторизации";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.cbName);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.dgPharmacy);
            this.tabPage2.Controls.Add(this.bInStock);
            this.tabPage2.Controls.Add(this.bDelete);
            this.tabPage2.Controls.Add(this.bAdd);
            this.tabPage2.Controls.Add(this.tbQuantity);
            this.tabPage2.Controls.Add(this.tbPrice);
            this.tabPage2.Controls.Add(this.tbName);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(789, 412);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Аптека";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(40, 281);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Наименование";
            // 
            // cbName
            // 
            this.cbName.FormattingEnabled = true;
            this.cbName.Location = new System.Drawing.Point(141, 281);
            this.cbName.Name = "cbName";
            this.cbName.Size = new System.Drawing.Size(122, 21);
            this.cbName.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(22, 237);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(168, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Удалите препарат";
            // 
            // dgPharmacy
            // 
            this.dgPharmacy.CaptionVisible = false;
            this.dgPharmacy.DataMember = "";
            this.dgPharmacy.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgPharmacy.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dgPharmacy.Location = new System.Drawing.Point(345, 3);
            this.dgPharmacy.Name = "dgPharmacy";
            this.dgPharmacy.Size = new System.Drawing.Size(441, 406);
            this.dgPharmacy.TabIndex = 10;
            // 
            // bInStock
            // 
            this.bInStock.Location = new System.Drawing.Point(103, 369);
            this.bInStock.Name = "bInStock";
            this.bInStock.Size = new System.Drawing.Size(137, 28);
            this.bInStock.TabIndex = 9;
            this.bInStock.Text = "В наличии";
            this.bInStock.UseVisualStyleBackColor = true;
            this.bInStock.Click += new System.EventHandler(this.bInStock_Click);
            // 
            // bDelete
            // 
            this.bDelete.Location = new System.Drawing.Point(103, 317);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(135, 23);
            this.bDelete.TabIndex = 8;
            this.bDelete.Text = "Удалить";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(103, 178);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(139, 23);
            this.bAdd.TabIndex = 7;
            this.bAdd.Text = "Добавить";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // tbQuantity
            // 
            this.tbQuantity.Location = new System.Drawing.Point(141, 138);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(122, 20);
            this.tbQuantity.TabIndex = 6;
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(141, 103);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(122, 20);
            this.tbPrice.TabIndex = 5;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(141, 65);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(122, 20);
            this.tbName.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(59, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Количество";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(98, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Цена";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(40, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Наименование";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(22, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Добавьте препарат";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.bOrders);
            this.tabPage3.Controls.Add(this.bSupply);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.cbOrder);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.dgOrders);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(789, 412);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Заказы";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // bSupply
            // 
            this.bSupply.Location = new System.Drawing.Point(94, 221);
            this.bSupply.Name = "bSupply";
            this.bSupply.Size = new System.Drawing.Size(132, 33);
            this.bSupply.TabIndex = 4;
            this.bSupply.Text = "Выдать";
            this.bSupply.UseVisualStyleBackColor = true;
            this.bSupply.Click += new System.EventHandler(this.bSupply_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(39, 157);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Номер заказа";
            // 
            // cbOrder
            // 
            this.cbOrder.FormattingEnabled = true;
            this.cbOrder.Location = new System.Drawing.Point(137, 157);
            this.cbOrder.Name = "cbOrder";
            this.cbOrder.Size = new System.Drawing.Size(140, 21);
            this.cbOrder.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(38, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(231, 40);
            this.label10.TabIndex = 1;
            this.label10.Text = "Выберите заказ, который \r\nхотите выдать";
            // 
            // dgOrders
            // 
            this.dgOrders.CaptionVisible = false;
            this.dgOrders.DataMember = "";
            this.dgOrders.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgOrders.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dgOrders.Location = new System.Drawing.Point(377, 0);
            this.dgOrders.Name = "dgOrders";
            this.dgOrders.Size = new System.Drawing.Size(412, 412);
            this.dgOrders.TabIndex = 0;
            // 
            // cn
            // 
            this.cn.ConnectionString = "Provider=SQLNCLI11;Data Source=DESKTOP-V4NPKHO;Persist Security Info=True;Passwor" +
    "d=sa;User ID=sa;Initial Catalog=hospital";
            // 
            // bOrders
            // 
            this.bOrders.Location = new System.Drawing.Point(94, 260);
            this.bOrders.Name = "bOrders";
            this.bOrders.Size = new System.Drawing.Size(132, 33);
            this.bOrders.TabIndex = 5;
            this.bOrders.Text = "Заказы";
            this.bOrders.UseVisualStyleBackColor = true;
            this.bOrders.Click += new System.EventHandler(this.bOrders_Click);
            // 
            // Pharmacy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Pharmacy";
            this.Text = "Pharmacy";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPharmacy)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button bLogIN;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Data.OleDb.OleDbConnection cn;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGrid dgPharmacy;
        private System.Windows.Forms.Button bInStock;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.TextBox tbQuantity;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button bSupply;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbOrder;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGrid dgOrders;
        private System.Windows.Forms.Button bOrders;
    }
}