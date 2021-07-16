namespace infSis
{
    partial class autorize
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(autorize));
            this.btnAut = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tbLog = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgwPolz = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pozlBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnReg = new System.Windows.Forms.Button();
            this.pozlBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgwPolz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pozlBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pozlBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAut
            // 
            this.btnAut.Location = new System.Drawing.Point(25, 120);
            this.btnAut.Name = "btnAut";
            this.btnAut.Size = new System.Drawing.Size(212, 73);
            this.btnAut.TabIndex = 0;
            this.btnAut.Text = "Авторизоваться";
            this.btnAut.UseVisualStyleBackColor = true;
            this.btnAut.Click += new System.EventHandler(this.btnAut_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(25, 204);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(212, 73);
            this.button2.TabIndex = 1;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // tbLog
            // 
            this.tbLog.Location = new System.Drawing.Point(89, 31);
            this.tbLog.Name = "tbLog";
            this.tbLog.Size = new System.Drawing.Size(148, 22);
            this.tbLog.TabIndex = 2;
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(89, 77);
            this.tbPass.Name = "tbPass";
            this.tbPass.PasswordChar = '★';
            this.tbPass.Size = new System.Drawing.Size(148, 22);
            this.tbPass.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Логин:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Пароль:";
            // 
            // dgwPolz
            // 
            this.dgwPolz.AllowUserToAddRows = false;
            this.dgwPolz.AllowUserToDeleteRows = false;
            this.dgwPolz.AutoGenerateColumns = false;
            this.dgwPolz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPolz.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.logDataGridViewTextBoxColumn,
            this.passDataGridViewTextBoxColumn});
            this.dgwPolz.DataSource = this.pozlBindingSource1;
            this.dgwPolz.Location = new System.Drawing.Point(25, 204);
            this.dgwPolz.Name = "dgwPolz";
            this.dgwPolz.ReadOnly = true;
            this.dgwPolz.RowHeadersWidth = 51;
            this.dgwPolz.RowTemplate.Height = 24;
            this.dgwPolz.Size = new System.Drawing.Size(212, 73);
            this.dgwPolz.TabIndex = 6;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // logDataGridViewTextBoxColumn
            // 
            this.logDataGridViewTextBoxColumn.DataPropertyName = "Log";
            this.logDataGridViewTextBoxColumn.HeaderText = "Log";
            this.logDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.logDataGridViewTextBoxColumn.Name = "logDataGridViewTextBoxColumn";
            this.logDataGridViewTextBoxColumn.ReadOnly = true;
            this.logDataGridViewTextBoxColumn.Width = 125;
            // 
            // passDataGridViewTextBoxColumn
            // 
            this.passDataGridViewTextBoxColumn.DataPropertyName = "Pass";
            this.passDataGridViewTextBoxColumn.HeaderText = "Pass";
            this.passDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.passDataGridViewTextBoxColumn.Name = "passDataGridViewTextBoxColumn";
            this.passDataGridViewTextBoxColumn.ReadOnly = true;
            this.passDataGridViewTextBoxColumn.Width = 125;
            // 
            // pozlBindingSource1
            // 
            this.pozlBindingSource1.DataSource = typeof(infSis.Model.Pozl);
            // 
            // btnReg
            // 
            this.btnReg.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnReg.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnReg.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F);
            this.btnReg.ForeColor = System.Drawing.SystemColors.Control;
            this.btnReg.Location = new System.Drawing.Point(0, 0);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(20, 20);
            this.btnReg.TabIndex = 7;
            this.btnReg.Text = "button1";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // pozlBindingSource
            // 
            this.pozlBindingSource.DataSource = typeof(infSis.Model.Pozl);
            // 
            // autorize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 289);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.tbLog);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAut);
            this.Controls.Add(this.dgwPolz);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "autorize";
            this.Text = "Авторизация";
            ((System.ComponentModel.ISupportInitialize)(this.dgwPolz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pozlBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pozlBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAut;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tbLog;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgwPolz;
        private System.Windows.Forms.BindingSource pozlBindingSource;
        private System.Windows.Forms.BindingSource pozlBindingSource1;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn logDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passDataGridViewTextBoxColumn;
    }
}