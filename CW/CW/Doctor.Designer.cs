namespace CW
{
    partial class Doctor
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
            this.dgVizits = new System.Windows.Forms.DataGrid();
            this.dgPatients = new System.Windows.Forms.DataGrid();
            this.bVizits = new System.Windows.Forms.Button();
            this.bPatients = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cbProcedure = new System.Windows.Forms.ComboBox();
            this.cbMedicament = new System.Windows.Forms.ComboBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.cbDiagnos = new System.Windows.Forms.ComboBox();
            this.bProcedure = new System.Windows.Forms.Button();
            this.bMedicament = new System.Windows.Forms.Button();
            this.bDiagnos = new System.Windows.Forms.Button();
            this.bSee = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbPatient = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dgDiagnos = new System.Windows.Forms.DataGrid();
            this.dgProcedure = new System.Windows.Forms.DataGrid();
            this.dgMedicament = new System.Windows.Forms.DataGrid();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVizits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPatients)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDiagnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProcedure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgMedicament)).BeginInit();
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
            this.tabControl1.Size = new System.Drawing.Size(800, 453);
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
            this.tabPage1.Size = new System.Drawing.Size(792, 427);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Вход";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // bLogIN
            // 
            this.bLogIN.Location = new System.Drawing.Point(310, 285);
            this.bLogIN.Name = "bLogIN";
            this.bLogIN.Size = new System.Drawing.Size(136, 35);
            this.bLogIN.TabIndex = 30;
            this.bLogIN.Text = "Войти";
            this.bLogIN.UseVisualStyleBackColor = true;
            this.bLogIN.Click += new System.EventHandler(this.bLogIN_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(310, 202);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(136, 20);
            this.tbPassword.TabIndex = 29;
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(310, 163);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(136, 20);
            this.tbLogin.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(250, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Пароль";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(250, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Логин";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(26, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 26);
            this.label1.TabIndex = 25;
            this.label1.Text = "Введите данные для авторизации";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.bPatients);
            this.tabPage2.Controls.Add(this.bVizits);
            this.tabPage2.Controls.Add(this.dgPatients);
            this.tabPage2.Controls.Add(this.dgVizits);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 427);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Приемы";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cn
            // 
            this.cn.ConnectionString = "Provider=SQLNCLI11;Data Source=DESKTOP-V4NPKHO;Persist Security Info=True;Passwor" +
    "d=sa;User ID=sa;Initial Catalog=hospital";
            // 
            // dgVizits
            // 
            this.dgVizits.CaptionVisible = false;
            this.dgVizits.DataMember = "";
            this.dgVizits.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dgVizits.Location = new System.Drawing.Point(8, 55);
            this.dgVizits.Name = "dgVizits";
            this.dgVizits.Size = new System.Drawing.Size(369, 361);
            this.dgVizits.TabIndex = 0;
            // 
            // dgPatients
            // 
            this.dgPatients.CaptionVisible = false;
            this.dgPatients.DataMember = "";
            this.dgPatients.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dgPatients.Location = new System.Drawing.Point(393, 6);
            this.dgPatients.Name = "dgPatients";
            this.dgPatients.Size = new System.Drawing.Size(391, 367);
            this.dgPatients.TabIndex = 1;
            // 
            // bVizits
            // 
            this.bVizits.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bVizits.Location = new System.Drawing.Point(8, 6);
            this.bVizits.Name = "bVizits";
            this.bVizits.Size = new System.Drawing.Size(369, 43);
            this.bVizits.TabIndex = 2;
            this.bVizits.Text = "Приемы";
            this.bVizits.UseVisualStyleBackColor = true;
            this.bVizits.Click += new System.EventHandler(this.bVizits_Click);
            // 
            // bPatients
            // 
            this.bPatients.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bPatients.Location = new System.Drawing.Point(393, 379);
            this.bPatients.Name = "bPatients";
            this.bPatients.Size = new System.Drawing.Size(391, 37);
            this.bPatients.TabIndex = 3;
            this.bPatients.Text = "Пациенты";
            this.bPatients.UseVisualStyleBackColor = true;
            this.bPatients.Click += new System.EventHandler(this.bPatients_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgMedicament);
            this.tabPage3.Controls.Add(this.dgProcedure);
            this.tabPage3.Controls.Add(this.dgDiagnos);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.cbPatient);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.bSee);
            this.tabPage3.Controls.Add(this.bDiagnos);
            this.tabPage3.Controls.Add(this.bMedicament);
            this.tabPage3.Controls.Add(this.bProcedure);
            this.tabPage3.Controls.Add(this.cbDiagnos);
            this.tabPage3.Controls.Add(this.cbStatus);
            this.tabPage3.Controls.Add(this.cbMedicament);
            this.tabPage3.Controls.Add(this.cbProcedure);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(792, 427);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Медкнижки";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // cbProcedure
            // 
            this.cbProcedure.FormattingEnabled = true;
            this.cbProcedure.Location = new System.Drawing.Point(117, 258);
            this.cbProcedure.Name = "cbProcedure";
            this.cbProcedure.Size = new System.Drawing.Size(121, 21);
            this.cbProcedure.TabIndex = 0;
            // 
            // cbMedicament
            // 
            this.cbMedicament.FormattingEnabled = true;
            this.cbMedicament.Location = new System.Drawing.Point(117, 340);
            this.cbMedicament.Name = "cbMedicament";
            this.cbMedicament.Size = new System.Drawing.Size(121, 21);
            this.cbMedicament.TabIndex = 1;
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(117, 156);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(121, 21);
            this.cbStatus.TabIndex = 2;
            // 
            // cbDiagnos
            // 
            this.cbDiagnos.FormattingEnabled = true;
            this.cbDiagnos.Location = new System.Drawing.Point(117, 117);
            this.cbDiagnos.Name = "cbDiagnos";
            this.cbDiagnos.Size = new System.Drawing.Size(121, 21);
            this.cbDiagnos.TabIndex = 3;
            // 
            // bProcedure
            // 
            this.bProcedure.Location = new System.Drawing.Point(126, 285);
            this.bProcedure.Name = "bProcedure";
            this.bProcedure.Size = new System.Drawing.Size(103, 38);
            this.bProcedure.TabIndex = 4;
            this.bProcedure.Text = "Назначить процедуру";
            this.bProcedure.UseVisualStyleBackColor = true;
            this.bProcedure.Click += new System.EventHandler(this.bProcedure_Click);
            // 
            // bMedicament
            // 
            this.bMedicament.Location = new System.Drawing.Point(126, 367);
            this.bMedicament.Name = "bMedicament";
            this.bMedicament.Size = new System.Drawing.Size(103, 37);
            this.bMedicament.TabIndex = 5;
            this.bMedicament.Text = "Выписать лекарство";
            this.bMedicament.UseVisualStyleBackColor = true;
            this.bMedicament.Click += new System.EventHandler(this.bMedicament_Click);
            // 
            // bDiagnos
            // 
            this.bDiagnos.Location = new System.Drawing.Point(126, 185);
            this.bDiagnos.Name = "bDiagnos";
            this.bDiagnos.Size = new System.Drawing.Size(103, 37);
            this.bDiagnos.TabIndex = 6;
            this.bDiagnos.Text = "Поставить диагноз";
            this.bDiagnos.UseVisualStyleBackColor = true;
            this.bDiagnos.Click += new System.EventHandler(this.bDiagnos_Click);
            // 
            // bSee
            // 
            this.bSee.Location = new System.Drawing.Point(305, 185);
            this.bSee.Name = "bSee";
            this.bSee.Size = new System.Drawing.Size(127, 38);
            this.bSee.TabIndex = 7;
            this.bSee.Text = "Посмотреть медкнижку";
            this.bSee.UseVisualStyleBackColor = true;
            this.bSee.Click += new System.EventHandler(this.bSee_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(595, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Лекарства";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(595, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Процедуры";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(26, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(260, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Медицинская книга пациента";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Пациент";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 258);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Процедура";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 340);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Лекарство";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(40, 117);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Диагноз";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(40, 156);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Статус";
            // 
            // cbPatient
            // 
            this.cbPatient.FormattingEnabled = true;
            this.cbPatient.Location = new System.Drawing.Point(117, 68);
            this.cbPatient.Name = "cbPatient";
            this.cbPatient.Size = new System.Drawing.Size(121, 21);
            this.cbPatient.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(595, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 20);
            this.label12.TabIndex = 17;
            this.label12.Text = "Диагнозы";
            // 
            // dgDiagnos
            // 
            this.dgDiagnos.CaptionVisible = false;
            this.dgDiagnos.DataMember = "";
            this.dgDiagnos.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dgDiagnos.Location = new System.Drawing.Point(493, 33);
            this.dgDiagnos.Name = "dgDiagnos";
            this.dgDiagnos.Size = new System.Drawing.Size(291, 105);
            this.dgDiagnos.TabIndex = 22;
            // 
            // dgProcedure
            // 
            this.dgProcedure.CaptionVisible = false;
            this.dgProcedure.DataMember = "";
            this.dgProcedure.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dgProcedure.Location = new System.Drawing.Point(493, 168);
            this.dgProcedure.Name = "dgProcedure";
            this.dgProcedure.Size = new System.Drawing.Size(291, 105);
            this.dgProcedure.TabIndex = 23;
            // 
            // dgMedicament
            // 
            this.dgMedicament.CaptionVisible = false;
            this.dgMedicament.DataMember = "";
            this.dgMedicament.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dgMedicament.Location = new System.Drawing.Point(493, 311);
            this.dgMedicament.Name = "dgMedicament";
            this.dgMedicament.Size = new System.Drawing.Size(291, 105);
            this.dgMedicament.TabIndex = 24;
            // 
            // Doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Doctor";
            this.Text = "Doctor";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgVizits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPatients)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDiagnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProcedure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgMedicament)).EndInit();
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
        private System.Windows.Forms.Button bPatients;
        private System.Windows.Forms.Button bVizits;
        private System.Windows.Forms.DataGrid dgPatients;
        private System.Windows.Forms.DataGrid dgVizits;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGrid dgMedicament;
        private System.Windows.Forms.DataGrid dgProcedure;
        private System.Windows.Forms.DataGrid dgDiagnos;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbPatient;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bSee;
        private System.Windows.Forms.Button bDiagnos;
        private System.Windows.Forms.Button bMedicament;
        private System.Windows.Forms.Button bProcedure;
        private System.Windows.Forms.ComboBox cbDiagnos;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.ComboBox cbMedicament;
        private System.Windows.Forms.ComboBox cbProcedure;
    }
}