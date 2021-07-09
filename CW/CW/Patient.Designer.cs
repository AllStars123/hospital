namespace CW
{
    partial class Patient
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
            this.bRegister = new System.Windows.Forms.Button();
            this.bLogIN = new System.Windows.Forms.Button();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.bReg = new System.Windows.Forms.Button();
            this.tbFIO = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbPassport = new System.Windows.Forms.TextBox();
            this.tbPolis = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.cbProcedure = new System.Windows.Forms.ComboBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.bSet = new System.Windows.Forms.Button();
            this.bPay = new System.Windows.Forms.Button();
            this.bShow = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dgProcedure = new System.Windows.Forms.DataGrid();
            this.dgDiagnos = new System.Windows.Forms.DataGrid();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.bDelete = new System.Windows.Forms.Button();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.cbMedicament = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.bAdd = new System.Windows.Forms.Button();
            this.bPayOrder = new System.Windows.Forms.Button();
            this.bShowMedicaments = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.dgOrder = new System.Windows.Forms.DataGrid();
            this.dgRecipe = new System.Windows.Forms.DataGrid();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tbAddBalans = new System.Windows.Forms.TextBox();
            this.tbBalans = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.cn = new System.Data.OleDb.OleDbConnection();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProcedure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDiagnos)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgRecipe)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(798, 438);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.bRegister);
            this.tabPage1.Controls.Add(this.bLogIN);
            this.tabPage1.Controls.Add(this.tbPassword);
            this.tabPage1.Controls.Add(this.tbLogin);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(790, 412);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Вход";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // bRegister
            // 
            this.bRegister.Location = new System.Drawing.Point(375, 280);
            this.bRegister.Name = "bRegister";
            this.bRegister.Size = new System.Drawing.Size(128, 31);
            this.bRegister.TabIndex = 13;
            this.bRegister.Text = "Зарегестрироваться";
            this.bRegister.UseVisualStyleBackColor = true;
            this.bRegister.Click += new System.EventHandler(this.bRegister_Click);
            // 
            // bLogIN
            // 
            this.bLogIN.Location = new System.Drawing.Point(242, 280);
            this.bLogIN.Name = "bLogIN";
            this.bLogIN.Size = new System.Drawing.Size(127, 31);
            this.bLogIN.TabIndex = 12;
            this.bLogIN.Text = "Войти";
            this.bLogIN.UseVisualStyleBackColor = true;
            this.bLogIN.Click += new System.EventHandler(this.bLogIN_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(311, 195);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(136, 20);
            this.tbPassword.TabIndex = 11;
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(311, 156);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(136, 20);
            this.tbLogin.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(251, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Пароль";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(251, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Логин";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(27, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "Введите данные для авторизации";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.bReg);
            this.tabPage2.Controls.Add(this.tbFIO);
            this.tabPage2.Controls.Add(this.tbPhone);
            this.tabPage2.Controls.Add(this.tbPassport);
            this.tabPage2.Controls.Add(this.tbPolis);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(790, 412);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Регистрация";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // bReg
            // 
            this.bReg.Location = new System.Drawing.Point(304, 349);
            this.bReg.Name = "bReg";
            this.bReg.Size = new System.Drawing.Size(182, 29);
            this.bReg.TabIndex = 27;
            this.bReg.Text = "Зарегестрироваться";
            this.bReg.UseVisualStyleBackColor = true;
            this.bReg.Click += new System.EventHandler(this.bReg_Click);
            // 
            // tbFIO
            // 
            this.tbFIO.Location = new System.Drawing.Point(360, 142);
            this.tbFIO.Name = "tbFIO";
            this.tbFIO.Size = new System.Drawing.Size(141, 20);
            this.tbFIO.TabIndex = 26;
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(360, 168);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(141, 20);
            this.tbPhone.TabIndex = 25;
            // 
            // tbPassport
            // 
            this.tbPassport.Location = new System.Drawing.Point(360, 194);
            this.tbPassport.Name = "tbPassport";
            this.tbPassport.Size = new System.Drawing.Size(141, 20);
            this.tbPassport.TabIndex = 24;
            // 
            // tbPolis
            // 
            this.tbPolis.Location = new System.Drawing.Point(360, 220);
            this.tbPolis.Name = "tbPolis";
            this.tbPolis.Size = new System.Drawing.Size(141, 20);
            this.tbPolis.TabIndex = 23;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(360, 246);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 20);
            this.textBox1.TabIndex = 22;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(360, 272);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(141, 20);
            this.textBox2.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(287, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Пароль";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(295, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Логин";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(294, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Полис";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(281, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Паспорт";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(231, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Номер телефона";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(301, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "ФИО";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(74, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(531, 26);
            this.label10.TabIndex = 14;
            this.label10.Text = "Введите данные для создания учетной записи";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label23);
            this.tabPage3.Controls.Add(this.label22);
            this.tabPage3.Controls.Add(this.cbProcedure);
            this.tabPage3.Controls.Add(this.cbStatus);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.bSet);
            this.tabPage3.Controls.Add(this.bPay);
            this.tabPage3.Controls.Add(this.bShow);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.dgProcedure);
            this.tabPage3.Controls.Add(this.dgDiagnos);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(790, 412);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Медкнижка";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(469, 257);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(62, 13);
            this.label23.TabIndex = 11;
            this.label23.Text = "Процедура";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(469, 298);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(41, 13);
            this.label22.TabIndex = 10;
            this.label22.Text = "Статус";
            // 
            // cbProcedure
            // 
            this.cbProcedure.FormattingEnabled = true;
            this.cbProcedure.Location = new System.Drawing.Point(537, 257);
            this.cbProcedure.Name = "cbProcedure";
            this.cbProcedure.Size = new System.Drawing.Size(121, 21);
            this.cbProcedure.TabIndex = 9;
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(537, 298);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(121, 21);
            this.cbStatus.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(494, 231);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(188, 13);
            this.label13.TabIndex = 7;
            this.label13.Text = "Установить статус процедуры";
            // 
            // bSet
            // 
            this.bSet.Location = new System.Drawing.Point(516, 351);
            this.bSet.Name = "bSet";
            this.bSet.Size = new System.Drawing.Size(84, 33);
            this.bSet.TabIndex = 6;
            this.bSet.Text = "Установить";
            this.bSet.UseVisualStyleBackColor = true;
            this.bSet.Click += new System.EventHandler(this.bSet_Click);
            // 
            // bPay
            // 
            this.bPay.Location = new System.Drawing.Point(144, 348);
            this.bPay.Name = "bPay";
            this.bPay.Size = new System.Drawing.Size(114, 33);
            this.bPay.TabIndex = 5;
            this.bPay.Text = "Оплатить";
            this.bPay.UseVisualStyleBackColor = true;
            this.bPay.Click += new System.EventHandler(this.bPay_Click);
            // 
            // bShow
            // 
            this.bShow.Location = new System.Drawing.Point(666, 15);
            this.bShow.Name = "bShow";
            this.bShow.Size = new System.Drawing.Size(103, 33);
            this.bShow.TabIndex = 4;
            this.bShow.Text = "Показать";
            this.bShow.UseVisualStyleBackColor = true;
            this.bShow.Click += new System.EventHandler(this.bShow_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(166, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 20);
            this.label12.TabIndex = 3;
            this.label12.Text = "Диагноз";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(154, 198);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 20);
            this.label11.TabIndex = 2;
            this.label11.Text = "Процедуры";
            // 
            // dgProcedure
            // 
            this.dgProcedure.CaptionVisible = false;
            this.dgProcedure.DataMember = "";
            this.dgProcedure.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dgProcedure.Location = new System.Drawing.Point(8, 231);
            this.dgProcedure.Name = "dgProcedure";
            this.dgProcedure.Size = new System.Drawing.Size(409, 111);
            this.dgProcedure.TabIndex = 1;
            // 
            // dgDiagnos
            // 
            this.dgDiagnos.CaptionVisible = false;
            this.dgDiagnos.DataMember = "";
            this.dgDiagnos.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dgDiagnos.Location = new System.Drawing.Point(8, 51);
            this.dgDiagnos.Name = "dgDiagnos";
            this.dgDiagnos.Size = new System.Drawing.Size(409, 111);
            this.dgDiagnos.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.bDelete);
            this.tabPage4.Controls.Add(this.tbQuantity);
            this.tabPage4.Controls.Add(this.label18);
            this.tabPage4.Controls.Add(this.label17);
            this.tabPage4.Controls.Add(this.cbMedicament);
            this.tabPage4.Controls.Add(this.label14);
            this.tabPage4.Controls.Add(this.bAdd);
            this.tabPage4.Controls.Add(this.bPayOrder);
            this.tabPage4.Controls.Add(this.bShowMedicaments);
            this.tabPage4.Controls.Add(this.label15);
            this.tabPage4.Controls.Add(this.label16);
            this.tabPage4.Controls.Add(this.dgOrder);
            this.tabPage4.Controls.Add(this.dgRecipe);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(790, 412);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Лекарства";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // bDelete
            // 
            this.bDelete.Location = new System.Drawing.Point(603, 356);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(87, 33);
            this.bDelete.TabIndex = 21;
            this.bDelete.Text = "Удалить";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // tbQuantity
            // 
            this.tbQuantity.Location = new System.Drawing.Point(580, 309);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(121, 20);
            this.tbQuantity.TabIndex = 20;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(508, 267);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(62, 13);
            this.label18.TabIndex = 19;
            this.label18.Text = "Лекарство";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(504, 309);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(66, 13);
            this.label17.TabIndex = 18;
            this.label17.Text = "Количество";
            // 
            // cbMedicament
            // 
            this.cbMedicament.FormattingEnabled = true;
            this.cbMedicament.Location = new System.Drawing.Point(580, 267);
            this.cbMedicament.Name = "cbMedicament";
            this.cbMedicament.Size = new System.Drawing.Size(121, 21);
            this.cbMedicament.TabIndex = 17;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(486, 239);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(128, 13);
            this.label14.TabIndex = 16;
            this.label14.Text = "Лекарства в заказе";
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(513, 356);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(84, 33);
            this.bAdd.TabIndex = 15;
            this.bAdd.Text = "Добавить";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // bPayOrder
            // 
            this.bPayOrder.Location = new System.Drawing.Point(151, 356);
            this.bPayOrder.Name = "bPayOrder";
            this.bPayOrder.Size = new System.Drawing.Size(114, 33);
            this.bPayOrder.TabIndex = 14;
            this.bPayOrder.Text = "Оплатить";
            this.bPayOrder.UseVisualStyleBackColor = true;
            this.bPayOrder.Click += new System.EventHandler(this.bPayOrder_Click);
            // 
            // bShowMedicaments
            // 
            this.bShowMedicaments.Location = new System.Drawing.Point(673, 23);
            this.bShowMedicaments.Name = "bShowMedicaments";
            this.bShowMedicaments.Size = new System.Drawing.Size(103, 33);
            this.bShowMedicaments.TabIndex = 13;
            this.bShowMedicaments.Text = "Показать";
            this.bShowMedicaments.UseVisualStyleBackColor = true;
            this.bShowMedicaments.Click += new System.EventHandler(this.bShowMedicaments_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(173, 28);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 20);
            this.label15.TabIndex = 12;
            this.label15.Text = "Рецепт";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(173, 206);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 20);
            this.label16.TabIndex = 11;
            this.label16.Text = "Заказ";
            // 
            // dgOrder
            // 
            this.dgOrder.CaptionVisible = false;
            this.dgOrder.DataMember = "";
            this.dgOrder.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dgOrder.Location = new System.Drawing.Point(15, 239);
            this.dgOrder.Name = "dgOrder";
            this.dgOrder.Size = new System.Drawing.Size(409, 111);
            this.dgOrder.TabIndex = 10;
            // 
            // dgRecipe
            // 
            this.dgRecipe.CaptionVisible = false;
            this.dgRecipe.DataMember = "";
            this.dgRecipe.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dgRecipe.Location = new System.Drawing.Point(15, 59);
            this.dgRecipe.Name = "dgRecipe";
            this.dgRecipe.Size = new System.Drawing.Size(409, 111);
            this.dgRecipe.TabIndex = 9;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.tbAddBalans);
            this.tabPage5.Controls.Add(this.tbBalans);
            this.tabPage5.Controls.Add(this.label21);
            this.tabPage5.Controls.Add(this.label20);
            this.tabPage5.Controls.Add(this.button2);
            this.tabPage5.Controls.Add(this.button1);
            this.tabPage5.Controls.Add(this.label19);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(790, 412);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Кошелёк";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tbAddBalans
            // 
            this.tbAddBalans.Location = new System.Drawing.Point(326, 227);
            this.tbAddBalans.Name = "tbAddBalans";
            this.tbAddBalans.Size = new System.Drawing.Size(116, 20);
            this.tbAddBalans.TabIndex = 6;
            // 
            // tbBalans
            // 
            this.tbBalans.Location = new System.Drawing.Point(326, 160);
            this.tbBalans.Name = "tbBalans";
            this.tbBalans.Size = new System.Drawing.Size(116, 20);
            this.tbBalans.TabIndex = 5;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(181, 227);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(104, 13);
            this.label21.TabIndex = 4;
            this.label21.Text = "Сумма пополнения";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(238, 160);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(44, 13);
            this.label20.TabIndex = 3;
            this.label20.Text = "Баланс";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(477, 148);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 42);
            this.button2.TabIndex = 2;
            this.button2.Text = "Посмотреть баланс";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(477, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "Пополнить баланс";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.Location = new System.Drawing.Point(313, 50);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(139, 24);
            this.label19.TabIndex = 0;
            this.label19.Text = "Мой кошелёк";
            // 
            // cn
            // 
            this.cn.ConnectionString = "Provider=SQLNCLI11;Data Source=DESKTOP-V4NPKHO;Persist Security Info=True;Passwor" +
    "d=sa;User ID=sa;Initial Catalog=hospital";
            // 
            // Patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Patient";
            this.Text = "Patient";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProcedure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDiagnos)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgRecipe)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button bRegister;
        private System.Windows.Forms.Button bLogIN;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bReg;
        private System.Windows.Forms.TextBox tbFIO;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbPassport;
        private System.Windows.Forms.TextBox tbPolis;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Data.OleDb.OleDbConnection cn;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button bSet;
        private System.Windows.Forms.Button bPay;
        private System.Windows.Forms.Button bShow;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGrid dgProcedure;
        private System.Windows.Forms.DataGrid dgDiagnos;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.TextBox tbQuantity;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cbMedicament;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bPayOrder;
        private System.Windows.Forms.Button bShowMedicaments;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGrid dgOrder;
        private System.Windows.Forms.DataGrid dgRecipe;
        private System.Windows.Forms.TextBox tbAddBalans;
        private System.Windows.Forms.TextBox tbBalans;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox cbProcedure;
    }
}