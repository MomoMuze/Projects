namespace infSis
{
    partial class reg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(reg));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.tbLog = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Пароль:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Логин:";
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(89, 77);
            this.tbPass.Name = "tbPass";
            this.tbPass.PasswordChar = '★';
            this.tbPass.Size = new System.Drawing.Size(148, 22);
            this.tbPass.TabIndex = 10;
            // 
            // tbLog
            // 
            this.tbLog.Location = new System.Drawing.Point(89, 31);
            this.tbLog.Name = "tbLog";
            this.tbLog.Size = new System.Drawing.Size(148, 22);
            this.tbLog.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(25, 199);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(212, 73);
            this.button2.TabIndex = 8;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnAut
            // 
            this.btnAut.Location = new System.Drawing.Point(25, 120);
            this.btnAut.Name = "btnAut";
            this.btnAut.Size = new System.Drawing.Size(212, 73);
            this.btnAut.TabIndex = 7;
            this.btnAut.Text = "Зарегистрироваться";
            this.btnAut.UseVisualStyleBackColor = true;
            this.btnAut.Click += new System.EventHandler(this.btnAut_Click);
            // 
            // reg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 289);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.tbLog);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAut);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "reg";
            this.Text = "Регистрация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.TextBox tbLog;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAut;
    }
}