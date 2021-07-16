using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using infSis.Model;

namespace infSis
{

    public partial class TypRed : Form
    {
        infSisContext db;
        string text = "Ошибка подключения к БД";
        string caption = "Ошибка";
        MessageBoxButtons buttons = MessageBoxButtons.OK;
        MessageBoxIcon icon = MessageBoxIcon.Error;
        public TypRed()
        {
            db = new infSisContext();
            InitializeComponent();
            try
            {
                db.Tipes.Load();
            dgvTip.AutoGenerateColumns = false;

            dgvTip.DataSource = db.Tipes.Local.ToBindingList();
            }
            catch
            {
                MessageBox.Show(this, text, caption, buttons, icon);
            }
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dgvTip_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            db.SaveChanges();

        }

        private void btnDobT_Click(object sender, EventArgs e)
        {
            Typ type = new Typ();

            if (type.ShowDialog(this) == DialogResult.Cancel)
                return;

            try
            {
                Tipe nType = new Tipe();
                nType.tipe = type.tbNewName.Text;
                db.Tipes.Add(nType);
                db.SaveChanges();
            }
            catch
            {
                MessageBox.Show(this, text, caption, buttons, icon);
            }
        }

        private void btnDelT_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Вы действительно хотите удалить тип?", "Удалить", MessageBoxButtons.OKCancel);

            if (result == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    int index = dgvTip.SelectedRows[0].Index;
                    int id = 0;
                    bool converted = Int32.TryParse(dgvTip[0, index].Value.ToString(), out id);
                    if (converted == false)
                        return;

                    Tipe delHis = db.Tipes.Find(id);
                    db.Tipes.Remove(delHis);
                    db.SaveChanges();
                }
                catch
                {
                    MessageBox.Show(this, text, caption, buttons, icon);
                }
            }
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            autorize auto = new autorize();

            if (auto.ShowDialog(this) == DialogResult.Cancel)
                return;
        }
    }
}
