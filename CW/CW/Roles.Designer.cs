namespace CW
{
    partial class Roles
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Roles));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonHD = new System.Windows.Forms.Button();
            this.buttonD = new System.Windows.Forms.Button();
            this.buttonP = new System.Windows.Forms.Button();
            this.buttonPatient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(132, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите свою роль";
            // 
            // buttonHD
            // 
            this.buttonHD.Location = new System.Drawing.Point(223, 176);
            this.buttonHD.Name = "buttonHD";
            this.buttonHD.Size = new System.Drawing.Size(112, 43);
            this.buttonHD.TabIndex = 1;
            this.buttonHD.Text = "ГЛАВВРАЧ";
            this.buttonHD.UseVisualStyleBackColor = true;
            this.buttonHD.Click += new System.EventHandler(this.buttonHD_Click);
            // 
            // buttonD
            // 
            this.buttonD.Location = new System.Drawing.Point(341, 176);
            this.buttonD.Name = "buttonD";
            this.buttonD.Size = new System.Drawing.Size(121, 43);
            this.buttonD.TabIndex = 2;
            this.buttonD.Text = "ВРАЧ";
            this.buttonD.UseVisualStyleBackColor = true;
            this.buttonD.Click += new System.EventHandler(this.buttonD_Click);
            // 
            // buttonP
            // 
            this.buttonP.Location = new System.Drawing.Point(223, 225);
            this.buttonP.Name = "buttonP";
            this.buttonP.Size = new System.Drawing.Size(112, 44);
            this.buttonP.TabIndex = 3;
            this.buttonP.Text = "АПТЕКАРЬ";
            this.buttonP.UseVisualStyleBackColor = true;
            this.buttonP.Click += new System.EventHandler(this.buttonP_Click);
            // 
            // buttonPatient
            // 
            this.buttonPatient.Location = new System.Drawing.Point(341, 225);
            this.buttonPatient.Name = "buttonPatient";
            this.buttonPatient.Size = new System.Drawing.Size(121, 44);
            this.buttonPatient.TabIndex = 4;
            this.buttonPatient.Text = "ПАЦИЕНТ";
            this.buttonPatient.UseVisualStyleBackColor = true;
            this.buttonPatient.Click += new System.EventHandler(this.buttonPatient_Click);
            // 
            // Roles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonPatient);
            this.Controls.Add(this.buttonP);
            this.Controls.Add(this.buttonD);
            this.Controls.Add(this.buttonHD);
            this.Controls.Add(this.label1);
            this.Name = "Roles";
            this.Text = "Roles";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonHD;
        private System.Windows.Forms.Button buttonD;
        private System.Windows.Forms.Button buttonP;
        private System.Windows.Forms.Button buttonPatient;
    }
}

