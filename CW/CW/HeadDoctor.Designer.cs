namespace CW
{
    partial class HeadDoctor
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
            this.cn = new System.Data.OleDb.OleDbConnection();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbFIO = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.tbLog = new System.Windows.Forms.TextBox();
            this.bDoctors = new System.Windows.Forms.Button();
            this.bHire = new System.Windows.Forms.Button();
            this.bFire = new System.Windows.Forms.Button();
            this.cbFIO = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dgDoctors = new System.Windows.Forms.DataGrid();
            this.dgProcedurs = new System.Windows.Forms.DataGrid();
            this.label11 = new System.Windows.Forms.Label();
            this.cbProcedurs = new System.Windows.Forms.ComboBox();
            this.bDelete = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            this.bProcedurs = new System.Windows.Forms.Button();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDoctors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProcedurs)).BeginInit();
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
            this.tabControl1.Size = new System.Drawing.Size(799, 446);
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
            this.tabPage1.Size = new System.Drawing.Size(791, 420);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Вход";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // bLogIN
            // 
            this.bLogIN.Location = new System.Drawing.Point(307, 287);
            this.bLogIN.Name = "bLogIN";
            this.bLogIN.Size = new System.Drawing.Size(136, 35);
            this.bLogIN.TabIndex = 24;
            this.bLogIN.Text = "Войти";
            this.bLogIN.UseVisualStyleBackColor = true;
            this.bLogIN.Click += new System.EventHandler(this.bLogIN_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(307, 204);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(136, 20);
            this.tbPassword.TabIndex = 23;
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(307, 165);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(136, 20);
            this.tbLogin.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(247, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Пароль";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(247, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Логин";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(23, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 26);
            this.label1.TabIndex = 19;
            this.label1.Text = "Введите данные для авторизации";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgDoctors);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.cbFIO);
            this.tabPage2.Controls.Add(this.bFire);
            this.tabPage2.Controls.Add(this.bHire);
            this.tabPage2.Controls.Add(this.bDoctors);
            this.tabPage2.Controls.Add(this.tbLog);
            this.tabPage2.Controls.Add(this.tbPass);
            this.tabPage2.Controls.Add(this.tbPhone);
            this.tabPage2.Controls.Add(this.tbFIO);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(791, 420);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Врачи";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cn
            // 
            this.cn.ConnectionString = "Provider=SQLNCLI11;Data Source=DESKTOP-V4NPKHO;Persist Security Info=True;Passwor" +
    "d=sa;User ID=sa;Initial Catalog=hospital";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgProcedurs);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.cbProcedurs);
            this.tabPage3.Controls.Add(this.bDelete);
            this.tabPage3.Controls.Add(this.bAdd);
            this.tabPage3.Controls.Add(this.bProcedurs);
            this.tabPage3.Controls.Add(this.tbPrice);
            this.tabPage3.Controls.Add(this.tbName);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(791, 420);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Процедуры";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(77, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Логин";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(408, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Уволить врача";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(41, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Нанять врача";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(83, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "ФИО";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(13, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Номер телефона";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(69, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Пароль";
            // 
            // tbFIO
            // 
            this.tbFIO.Location = new System.Drawing.Point(126, 59);
            this.tbFIO.Name = "tbFIO";
            this.tbFIO.Size = new System.Drawing.Size(100, 20);
            this.tbFIO.TabIndex = 6;
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(126, 94);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(100, 20);
            this.tbPhone.TabIndex = 7;
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(126, 132);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(100, 20);
            this.tbPass.TabIndex = 8;
            // 
            // tbLog
            // 
            this.tbLog.Location = new System.Drawing.Point(126, 170);
            this.tbLog.Name = "tbLog";
            this.tbLog.Size = new System.Drawing.Size(100, 20);
            this.tbLog.TabIndex = 9;
            // 
            // bDoctors
            // 
            this.bDoctors.Location = new System.Drawing.Point(342, 258);
            this.bDoctors.Name = "bDoctors";
            this.bDoctors.Size = new System.Drawing.Size(75, 23);
            this.bDoctors.TabIndex = 10;
            this.bDoctors.Text = "Все врачи";
            this.bDoctors.UseVisualStyleBackColor = true;
            this.bDoctors.Click += new System.EventHandler(this.bDoctors_Click);
            // 
            // bHire
            // 
            this.bHire.Location = new System.Drawing.Point(138, 224);
            this.bHire.Name = "bHire";
            this.bHire.Size = new System.Drawing.Size(75, 23);
            this.bHire.TabIndex = 11;
            this.bHire.Text = "Нанять";
            this.bHire.UseVisualStyleBackColor = true;
            this.bHire.Click += new System.EventHandler(this.bHire_Click);
            // 
            // bFire
            // 
            this.bFire.Location = new System.Drawing.Point(448, 117);
            this.bFire.Name = "bFire";
            this.bFire.Size = new System.Drawing.Size(75, 23);
            this.bFire.TabIndex = 12;
            this.bFire.Text = "Уволить";
            this.bFire.UseVisualStyleBackColor = true;
            this.bFire.Click += new System.EventHandler(this.bFire_Click);
            // 
            // cbFIO
            // 
            this.cbFIO.FormattingEnabled = true;
            this.cbFIO.Location = new System.Drawing.Point(458, 56);
            this.cbFIO.Name = "cbFIO";
            this.cbFIO.Size = new System.Drawing.Size(121, 21);
            this.cbFIO.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(415, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "ФИО";
            // 
            // dgDoctors
            // 
            this.dgDoctors.CaptionVisible = false;
            this.dgDoctors.DataMember = "";
            this.dgDoctors.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgDoctors.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dgDoctors.Location = new System.Drawing.Point(3, 287);
            this.dgDoctors.Name = "dgDoctors";
            this.dgDoctors.Size = new System.Drawing.Size(785, 130);
            this.dgDoctors.TabIndex = 15;
            // 
            // dgProcedurs
            // 
            this.dgProcedurs.CaptionVisible = false;
            this.dgProcedurs.DataMember = "";
            this.dgProcedurs.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgProcedurs.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dgProcedurs.Location = new System.Drawing.Point(0, 290);
            this.dgProcedurs.Name = "dgProcedurs";
            this.dgProcedurs.Size = new System.Drawing.Size(791, 130);
            this.dgProcedurs.TabIndex = 31;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(381, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "Процедура";
            // 
            // cbProcedurs
            // 
            this.cbProcedurs.FormattingEnabled = true;
            this.cbProcedurs.Location = new System.Drawing.Point(458, 50);
            this.cbProcedurs.Name = "cbProcedurs";
            this.cbProcedurs.Size = new System.Drawing.Size(121, 21);
            this.cbProcedurs.TabIndex = 29;
            // 
            // bDelete
            // 
            this.bDelete.Location = new System.Drawing.Point(448, 111);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(75, 23);
            this.bDelete.TabIndex = 28;
            this.bDelete.Text = "Убрать";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(99, 128);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(75, 23);
            this.bAdd.TabIndex = 27;
            this.bAdd.Text = "Добавить";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // bProcedurs
            // 
            this.bProcedurs.Location = new System.Drawing.Point(342, 252);
            this.bProcedurs.Name = "bProcedurs";
            this.bProcedurs.Size = new System.Drawing.Size(110, 32);
            this.bProcedurs.TabIndex = 26;
            this.bProcedurs.Text = "Все процедуры";
            this.bProcedurs.UseVisualStyleBackColor = true;
            this.bProcedurs.Click += new System.EventHandler(this.bProcedurs_Click);
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(126, 88);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(100, 20);
            this.tbPrice.TabIndex = 23;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(126, 53);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 20);
            this.tbName.TabIndex = 22;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(49, 88);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "Стоимость";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(49, 53);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 13);
            this.label14.TabIndex = 19;
            this.label14.Text = "Процедура";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(41, 6);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(185, 20);
            this.label15.TabIndex = 18;
            this.label15.Text = "Добавить процедуру";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(408, 6);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(163, 20);
            this.label16.TabIndex = 17;
            this.label16.Text = "Убрать процедуру";
            // 
            // HeadDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "HeadDoctor";
            this.Text = "HeadDoctor";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDoctors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProcedurs)).EndInit();
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
        private System.Windows.Forms.DataGrid dgDoctors;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbFIO;
        private System.Windows.Forms.Button bFire;
        private System.Windows.Forms.Button bHire;
        private System.Windows.Forms.Button bDoctors;
        private System.Windows.Forms.TextBox tbLog;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbFIO;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGrid dgProcedurs;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbProcedurs;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bProcedurs;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
    }
}