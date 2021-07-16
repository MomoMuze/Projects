namespace infSis
{
    partial class Pla
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pla));
            this.SnNew = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddPlat = new System.Windows.Forms.Button();
            this.cmbPlatTipe = new System.Windows.Forms.ComboBox();
            this.dannBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dannBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // SnNew
            // 
            this.SnNew.Location = new System.Drawing.Point(252, 95);
            this.SnNew.Margin = new System.Windows.Forms.Padding(4);
            this.SnNew.Name = "SnNew";
            this.SnNew.Size = new System.Drawing.Size(159, 22);
            this.SnNew.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выберите тип каплера";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введите серийный номер каплера";
            // 
            // btnAddPlat
            // 
            this.btnAddPlat.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAddPlat.Location = new System.Drawing.Point(252, 154);
            this.btnAddPlat.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddPlat.Name = "btnAddPlat";
            this.btnAddPlat.Size = new System.Drawing.Size(160, 57);
            this.btnAddPlat.TabIndex = 4;
            this.btnAddPlat.Text = "Добавить";
            this.btnAddPlat.UseVisualStyleBackColor = true;
            // 
            // cmbPlatTipe
            // 
            this.cmbPlatTipe.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dannBindingSource, "TipeId", true));
            this.cmbPlatTipe.DataSource = this.dannBindingSource;
            this.cmbPlatTipe.DisplayMember = "Tipe";
            this.cmbPlatTipe.FormattingEnabled = true;
            this.cmbPlatTipe.Location = new System.Drawing.Point(252, 31);
            this.cmbPlatTipe.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPlatTipe.Name = "cmbPlatTipe";
            this.cmbPlatTipe.Size = new System.Drawing.Size(160, 24);
            this.cmbPlatTipe.TabIndex = 5;
            this.cmbPlatTipe.ValueMember = "Tipe";
            // 
            // dannBindingSource
            // 
            this.dannBindingSource.DataSource = typeof(infSis.Model.Dann);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(47, 154);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 57);
            this.button1.TabIndex = 6;
            this.button1.Text = "Отмена";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Pla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 244);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbPlatTipe);
            this.Controls.Add(this.btnAddPlat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SnNew);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Pla";
            this.Text = "Добавление каплеров";
            ((System.ComponentModel.ISupportInitialize)(this.dannBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox SnNew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddPlat;
        public System.Windows.Forms.ComboBox cmbPlatTipe;
        private System.Windows.Forms.BindingSource dannBindingSource;
        private System.Windows.Forms.Button button1;
    }
}