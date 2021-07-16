namespace infSis
{
    partial class TypRed
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TypRed));
            this.dgvTip = new System.Windows.Forms.DataGridView();
            this.tipeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnDobT = new System.Windows.Forms.Button();
            this.btnDelT = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.min1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.max1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.min2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.max2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minOtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxOtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dannTipeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTip
            // 
            this.dgvTip.AllowUserToAddRows = false;
            this.dgvTip.AllowUserToDeleteRows = false;
            this.dgvTip.AutoGenerateColumns = false;
            this.dgvTip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTip.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.tipeDataGridViewTextBoxColumn,
            this.min1DataGridViewTextBoxColumn,
            this.max1DataGridViewTextBoxColumn,
            this.min2DataGridViewTextBoxColumn,
            this.max2DataGridViewTextBoxColumn,
            this.minOtDataGridViewTextBoxColumn,
            this.maxOtDataGridViewTextBoxColumn,
            this.dannTipeDataGridViewTextBoxColumn});
            this.dgvTip.DataSource = this.tipeBindingSource;
            this.dgvTip.Location = new System.Drawing.Point(1, 76);
            this.dgvTip.Name = "dgvTip";
            this.dgvTip.RowHeadersWidth = 51;
            this.dgvTip.RowTemplate.Height = 24;
            this.dgvTip.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTip.Size = new System.Drawing.Size(1378, 576);
            this.dgvTip.TabIndex = 0;
            this.dgvTip.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTip_CellEndEdit);
            this.dgvTip.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            // 
            // tipeBindingSource
            // 
            this.tipeBindingSource.DataSource = typeof(infSis.Model.Tipe);
            // 
            // btnDobT
            // 
            this.btnDobT.Location = new System.Drawing.Point(12, 12);
            this.btnDobT.Name = "btnDobT";
            this.btnDobT.Size = new System.Drawing.Size(163, 58);
            this.btnDobT.TabIndex = 5;
            this.btnDobT.Text = "Добавить";
            this.btnDobT.UseVisualStyleBackColor = true;
            this.btnDobT.Click += new System.EventHandler(this.btnDobT_Click);
            // 
            // btnDelT
            // 
            this.btnDelT.Location = new System.Drawing.Point(181, 12);
            this.btnDelT.Name = "btnDelT";
            this.btnDelT.Size = new System.Drawing.Size(163, 58);
            this.btnDelT.TabIndex = 7;
            this.btnDelT.Text = "Удалить";
            this.btnDelT.UseVisualStyleBackColor = true;
            this.btnDelT.Click += new System.EventHandler(this.btnDelT_Click);
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
            // tipeDataGridViewTextBoxColumn
            // 
            this.tipeDataGridViewTextBoxColumn.DataPropertyName = "tipe";
            this.tipeDataGridViewTextBoxColumn.HeaderText = "Наименование типа";
            this.tipeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tipeDataGridViewTextBoxColumn.Name = "tipeDataGridViewTextBoxColumn";
            this.tipeDataGridViewTextBoxColumn.Width = 125;
            // 
            // min1DataGridViewTextBoxColumn
            // 
            this.min1DataGridViewTextBoxColumn.DataPropertyName = "min1";
            this.min1DataGridViewTextBoxColumn.HeaderText = "Нижняя граница 1";
            this.min1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.min1DataGridViewTextBoxColumn.Name = "min1DataGridViewTextBoxColumn";
            this.min1DataGridViewTextBoxColumn.Width = 125;
            // 
            // max1DataGridViewTextBoxColumn
            // 
            this.max1DataGridViewTextBoxColumn.DataPropertyName = "max1";
            this.max1DataGridViewTextBoxColumn.HeaderText = "Верхняя граница 1";
            this.max1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.max1DataGridViewTextBoxColumn.Name = "max1DataGridViewTextBoxColumn";
            this.max1DataGridViewTextBoxColumn.Width = 125;
            // 
            // min2DataGridViewTextBoxColumn
            // 
            this.min2DataGridViewTextBoxColumn.DataPropertyName = "min2";
            this.min2DataGridViewTextBoxColumn.HeaderText = "Нижняя граница 2";
            this.min2DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.min2DataGridViewTextBoxColumn.Name = "min2DataGridViewTextBoxColumn";
            this.min2DataGridViewTextBoxColumn.Width = 125;
            // 
            // max2DataGridViewTextBoxColumn
            // 
            this.max2DataGridViewTextBoxColumn.DataPropertyName = "max2";
            this.max2DataGridViewTextBoxColumn.HeaderText = "Верхняя граница 2";
            this.max2DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.max2DataGridViewTextBoxColumn.Name = "max2DataGridViewTextBoxColumn";
            this.max2DataGridViewTextBoxColumn.Width = 125;
            // 
            // minOtDataGridViewTextBoxColumn
            // 
            this.minOtDataGridViewTextBoxColumn.DataPropertyName = "minOt";
            this.minOtDataGridViewTextBoxColumn.HeaderText = "Нижняя граница отношения";
            this.minOtDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.minOtDataGridViewTextBoxColumn.Name = "minOtDataGridViewTextBoxColumn";
            this.minOtDataGridViewTextBoxColumn.Width = 125;
            // 
            // maxOtDataGridViewTextBoxColumn
            // 
            this.maxOtDataGridViewTextBoxColumn.DataPropertyName = "maxOt";
            this.maxOtDataGridViewTextBoxColumn.HeaderText = "Верхняя граница отношения";
            this.maxOtDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maxOtDataGridViewTextBoxColumn.Name = "maxOtDataGridViewTextBoxColumn";
            this.maxOtDataGridViewTextBoxColumn.Width = 125;
            // 
            // dannTipeDataGridViewTextBoxColumn
            // 
            this.dannTipeDataGridViewTextBoxColumn.DataPropertyName = "DannTipe";
            this.dannTipeDataGridViewTextBoxColumn.HeaderText = "DannTipe";
            this.dannTipeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dannTipeDataGridViewTextBoxColumn.Name = "dannTipeDataGridViewTextBoxColumn";
            this.dannTipeDataGridViewTextBoxColumn.Visible = false;
            this.dannTipeDataGridViewTextBoxColumn.Width = 125;
            // 
            // TypRed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1379, 652);
            this.Controls.Add(this.btnDelT);
            this.Controls.Add(this.btnDobT);
            this.Controls.Add(this.dgvTip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TypRed";
            this.Text = "Редактиирование параметров типа";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvTip;
        public System.Windows.Forms.BindingSource tipeBindingSource;
        private System.Windows.Forms.Button btnDobT;
        private System.Windows.Forms.Button btnDelT;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn min1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn max1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn min2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn max2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minOtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxOtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dannTipeDataGridViewTextBoxColumn;
    }
}