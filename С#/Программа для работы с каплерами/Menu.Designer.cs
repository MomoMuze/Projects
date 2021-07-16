namespace infSis
{
    partial class Menu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.dgvDann = new System.Windows.Forms.DataGridView();
            this.dannBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnObn = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.btnSerch = new System.Windows.Forms.Button();
            this.tbPoiskPlat = new System.Windows.Forms.TextBox();
            this.btnDobP = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPdf = new System.Windows.Forms.Button();
            this.bthDelP = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRed = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblNeProv = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblAll = new System.Windows.Forms.Label();
            this.lblNeGodn = new System.Windows.Forms.Label();
            this.lblGodn = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tipeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.snDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ep1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ep2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fp1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pr1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fp2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pr2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datePosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateProvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDann)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dannBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDann
            // 
            this.dgvDann.AllowUserToAddRows = false;
            this.dgvDann.AllowUserToDeleteRows = false;
            this.dgvDann.AutoGenerateColumns = false;
            this.dgvDann.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDann.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.tipeIdDataGridViewTextBoxColumn,
            this.tipeDataGridViewTextBoxColumn1,
            this.snDataGridViewTextBoxColumn,
            this.ep1DataGridViewTextBoxColumn,
            this.ep2DataGridViewTextBoxColumn,
            this.fp1DataGridViewTextBoxColumn,
            this.pr1,
            this.fp2DataGridViewTextBoxColumn,
            this.pr2,
            this.datePosDataGridViewTextBoxColumn,
            this.dateProvDataGridViewTextBoxColumn,
            this.resultDataGridViewTextBoxColumn,
            this.resh});
            this.dgvDann.DataSource = this.dannBindingSource;
            this.dgvDann.Location = new System.Drawing.Point(0, 65);
            this.dgvDann.Name = "dgvDann";
            this.dgvDann.RowHeadersWidth = 51;
            this.dgvDann.RowTemplate.Height = 24;
            this.dgvDann.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDann.Size = new System.Drawing.Size(1538, 559);
            this.dgvDann.TabIndex = 1;
            this.dgvDann.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDann_CellEndEdit);
            this.dgvDann.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvDann_DataError);
            // 
            // dannBindingSource
            // 
            this.dannBindingSource.DataSource = typeof(infSis.Model.Dann);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnObn);
            this.groupBox1.Controls.Add(this.btnAll);
            this.groupBox1.Controls.Add(this.btnSerch);
            this.groupBox1.Controls.Add(this.tbPoiskPlat);
            this.groupBox1.Controls.Add(this.btnDobP);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnPdf);
            this.groupBox1.Controls.Add(this.bthDelP);
            this.groupBox1.Controls.Add(this.dgvDann);
            this.groupBox1.Location = new System.Drawing.Point(12, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1538, 632);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Список каплеров";
            // 
            // btnObn
            // 
            this.btnObn.Location = new System.Drawing.Point(234, 22);
            this.btnObn.Name = "btnObn";
            this.btnObn.Size = new System.Drawing.Size(108, 37);
            this.btnObn.TabIndex = 9;
            this.btnObn.Text = "Обновить";
            this.btnObn.UseVisualStyleBackColor = true;
            this.btnObn.Click += new System.EventHandler(this.btnObn_Click);
            // 
            // btnAll
            // 
            this.btnAll.Location = new System.Drawing.Point(982, 19);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(108, 37);
            this.btnAll.TabIndex = 8;
            this.btnAll.Text = "Показать все";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnSerch
            // 
            this.btnSerch.Location = new System.Drawing.Point(868, 19);
            this.btnSerch.Name = "btnSerch";
            this.btnSerch.Size = new System.Drawing.Size(108, 37);
            this.btnSerch.TabIndex = 7;
            this.btnSerch.Text = "Найти";
            this.btnSerch.UseVisualStyleBackColor = true;
            this.btnSerch.Click += new System.EventHandler(this.btnSerch_Click);
            // 
            // tbPoiskPlat
            // 
            this.tbPoiskPlat.Location = new System.Drawing.Point(545, 29);
            this.tbPoiskPlat.Name = "tbPoiskPlat";
            this.tbPoiskPlat.Size = new System.Drawing.Size(298, 26);
            this.tbPoiskPlat.TabIndex = 5;
            this.tbPoiskPlat.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbPoiskPlat_KeyUp);
            // 
            // btnDobP
            // 
            this.btnDobP.Location = new System.Drawing.Point(6, 22);
            this.btnDobP.Name = "btnDobP";
            this.btnDobP.Size = new System.Drawing.Size(108, 37);
            this.btnDobP.TabIndex = 0;
            this.btnDobP.Text = "Добавить";
            this.btnDobP.UseVisualStyleBackColor = true;
            this.btnDobP.Click += new System.EventHandler(this.btnDobP_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(469, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Поиск S/N";
            // 
            // btnPdf
            // 
            this.btnPdf.Location = new System.Drawing.Point(1234, 19);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(143, 37);
            this.btnPdf.TabIndex = 3;
            this.btnPdf.Text = "Сохранить отчёт";
            this.btnPdf.UseVisualStyleBackColor = true;
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click_1);
            // 
            // bthDelP
            // 
            this.bthDelP.Location = new System.Drawing.Point(120, 22);
            this.bthDelP.Name = "bthDelP";
            this.bthDelP.Size = new System.Drawing.Size(108, 37);
            this.bthDelP.TabIndex = 2;
            this.bthDelP.Text = "Удалить";
            this.bthDelP.UseVisualStyleBackColor = true;
            this.bthDelP.Click += new System.EventHandler(this.bthDelP_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRed);
            this.groupBox2.Location = new System.Drawing.Point(12, 631);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 101);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Типы каплеров";
            // 
            // btnRed
            // 
            this.btnRed.Location = new System.Drawing.Point(0, 25);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(189, 68);
            this.btnRed.TabIndex = 9;
            this.btnRed.Text = "Просмотр и редактирование";
            this.btnRed.UseVisualStyleBackColor = true;
            this.btnRed.Click += new System.EventHandler(this.btnRed_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblNeProv);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.lblAll);
            this.groupBox3.Controls.Add(this.lblNeGodn);
            this.groupBox3.Controls.Add(this.lblGodn);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(246, 631);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1289, 101);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Общее количество и % годности";
            // 
            // lblNeProv
            // 
            this.lblNeProv.AutoSize = true;
            this.lblNeProv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNeProv.Location = new System.Drawing.Point(1226, 36);
            this.lblNeProv.Name = "lblNeProv";
            this.lblNeProv.Size = new System.Drawing.Size(18, 25);
            this.lblNeProv.TabIndex = 7;
            this.lblNeProv.Text = "/";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(929, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(272, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Количество не провереных:";
            // 
            // lblAll
            // 
            this.lblAll.AutoSize = true;
            this.lblAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblAll.Location = new System.Drawing.Point(253, 36);
            this.lblAll.Name = "lblAll";
            this.lblAll.Size = new System.Drawing.Size(18, 25);
            this.lblAll.TabIndex = 5;
            this.lblAll.Text = "/";
            // 
            // lblNeGodn
            // 
            this.lblNeGodn.AutoSize = true;
            this.lblNeGodn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNeGodn.Location = new System.Drawing.Point(866, 36);
            this.lblNeGodn.Name = "lblNeGodn";
            this.lblNeGodn.Size = new System.Drawing.Size(18, 25);
            this.lblNeGodn.TabIndex = 4;
            this.lblNeGodn.Text = "/";
            // 
            // lblGodn
            // 
            this.lblGodn.AutoSize = true;
            this.lblGodn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblGodn.Location = new System.Drawing.Point(535, 36);
            this.lblGodn.Name = "lblGodn";
            this.lblGodn.Size = new System.Drawing.Size(18, 25);
            this.lblGodn.TabIndex = 3;
            this.lblGodn.Text = "/";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(603, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(227, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Количество не годных:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(306, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Количество годных:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(20, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Общее количество:";
            // 
            // tipeBindingSource
            // 
            this.tipeBindingSource.DataSource = typeof(infSis.Model.Tipe);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Visible = false;
            this.idDataGridViewTextBoxColumn1.Width = 70;
            // 
            // tipeIdDataGridViewTextBoxColumn
            // 
            this.tipeIdDataGridViewTextBoxColumn.DataPropertyName = "TipeId";
            this.tipeIdDataGridViewTextBoxColumn.HeaderText = "TipeId";
            this.tipeIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tipeIdDataGridViewTextBoxColumn.Name = "tipeIdDataGridViewTextBoxColumn";
            this.tipeIdDataGridViewTextBoxColumn.Visible = false;
            this.tipeIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // tipeDataGridViewTextBoxColumn1
            // 
            this.tipeDataGridViewTextBoxColumn1.DataPropertyName = "Tipe";
            this.tipeDataGridViewTextBoxColumn1.HeaderText = "Тип";
            this.tipeDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.tipeDataGridViewTextBoxColumn1.Name = "tipeDataGridViewTextBoxColumn1";
            this.tipeDataGridViewTextBoxColumn1.ReadOnly = true;
            this.tipeDataGridViewTextBoxColumn1.Width = 70;
            // 
            // snDataGridViewTextBoxColumn
            // 
            this.snDataGridViewTextBoxColumn.DataPropertyName = "sn";
            this.snDataGridViewTextBoxColumn.HeaderText = "S/N";
            this.snDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.snDataGridViewTextBoxColumn.Name = "snDataGridViewTextBoxColumn";
            this.snDataGridViewTextBoxColumn.Width = 70;
            // 
            // ep1DataGridViewTextBoxColumn
            // 
            this.ep1DataGridViewTextBoxColumn.DataPropertyName = "ep1";
            this.ep1DataGridViewTextBoxColumn.HeaderText = "Заявленные потери 1";
            this.ep1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ep1DataGridViewTextBoxColumn.Name = "ep1DataGridViewTextBoxColumn";
            this.ep1DataGridViewTextBoxColumn.Width = 125;
            // 
            // ep2DataGridViewTextBoxColumn
            // 
            this.ep2DataGridViewTextBoxColumn.DataPropertyName = "ep2";
            this.ep2DataGridViewTextBoxColumn.HeaderText = "Заявленные потери 2";
            this.ep2DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ep2DataGridViewTextBoxColumn.Name = "ep2DataGridViewTextBoxColumn";
            this.ep2DataGridViewTextBoxColumn.Width = 125;
            // 
            // fp1DataGridViewTextBoxColumn
            // 
            this.fp1DataGridViewTextBoxColumn.DataPropertyName = "fp1";
            this.fp1DataGridViewTextBoxColumn.HeaderText = "Фактические потери 1";
            this.fp1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fp1DataGridViewTextBoxColumn.Name = "fp1DataGridViewTextBoxColumn";
            this.fp1DataGridViewTextBoxColumn.Width = 125;
            // 
            // pr1
            // 
            this.pr1.DataPropertyName = "pr1";
            this.pr1.HeaderText = "Процент 1";
            this.pr1.MinimumWidth = 6;
            this.pr1.Name = "pr1";
            this.pr1.ReadOnly = true;
            this.pr1.Width = 125;
            // 
            // fp2DataGridViewTextBoxColumn
            // 
            this.fp2DataGridViewTextBoxColumn.DataPropertyName = "fp2";
            this.fp2DataGridViewTextBoxColumn.HeaderText = "Фактические потери 2";
            this.fp2DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fp2DataGridViewTextBoxColumn.Name = "fp2DataGridViewTextBoxColumn";
            this.fp2DataGridViewTextBoxColumn.Width = 125;
            // 
            // pr2
            // 
            this.pr2.DataPropertyName = "pr2";
            this.pr2.HeaderText = "Процент 2";
            this.pr2.MinimumWidth = 6;
            this.pr2.Name = "pr2";
            this.pr2.ReadOnly = true;
            this.pr2.Width = 125;
            // 
            // datePosDataGridViewTextBoxColumn
            // 
            this.datePosDataGridViewTextBoxColumn.DataPropertyName = "datePos";
            this.datePosDataGridViewTextBoxColumn.HeaderText = "Дата поступления";
            this.datePosDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.datePosDataGridViewTextBoxColumn.Name = "datePosDataGridViewTextBoxColumn";
            this.datePosDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateProvDataGridViewTextBoxColumn
            // 
            this.dateProvDataGridViewTextBoxColumn.DataPropertyName = "dateProv";
            this.dateProvDataGridViewTextBoxColumn.HeaderText = "Дата проверки";
            this.dateProvDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateProvDataGridViewTextBoxColumn.Name = "dateProvDataGridViewTextBoxColumn";
            this.dateProvDataGridViewTextBoxColumn.Width = 125;
            // 
            // resultDataGridViewTextBoxColumn
            // 
            this.resultDataGridViewTextBoxColumn.DataPropertyName = "result";
            this.resultDataGridViewTextBoxColumn.HeaderText = "Отношение";
            this.resultDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.resultDataGridViewTextBoxColumn.Name = "resultDataGridViewTextBoxColumn";
            this.resultDataGridViewTextBoxColumn.ReadOnly = true;
            this.resultDataGridViewTextBoxColumn.Width = 125;
            // 
            // resh
            // 
            this.resh.DataPropertyName = "resh";
            this.resh.HeaderText = "Решение";
            this.resh.MinimumWidth = 6;
            this.resh.Name = "resh";
            this.resh.ReadOnly = true;
            this.resh.Width = 125;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1548, 744);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Menu";
            this.Text = "Меню";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDann)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dannBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbPoiskPlat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPdf;
        private System.Windows.Forms.Button bthDelP;
        private System.Windows.Forms.Button btnDobP;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Button btnSerch;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblAll;
        private System.Windows.Forms.Label lblNeGodn;
        private System.Windows.Forms.Label lblGodn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRed;
        public System.Windows.Forms.BindingSource tipeBindingSource;
        private System.Windows.Forms.Button btnObn;
        public System.Windows.Forms.DataGridView dgvDann;
        public System.Windows.Forms.BindingSource dannBindingSource;
        private System.Windows.Forms.Label lblNeProv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn snDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ep1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ep2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fp1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pr1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fp2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pr2;
        private System.Windows.Forms.DataGridViewTextBoxColumn datePosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateProvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resh;
    }
}

