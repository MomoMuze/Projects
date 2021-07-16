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
using System.IO;
using infSis;


namespace infSis
{
    public partial class autorize : Form
    {
        infSisContext db;
        string text = "Ошибка подключения к БД";
        string text1 = "Не верный логин или пароль";
        string caption = "Ошибка";
        MessageBoxButtons buttons = MessageBoxButtons.OK;
        MessageBoxIcon icon = MessageBoxIcon.Error;

        public autorize()
        {
            InitializeComponent();
            db = new infSisContext();
            try
            {
                db.Pozls.Load();
                dgwPolz.AutoGenerateColumns = false;
                dgwPolz.DataSource = db.Pozls.Local.ToBindingList();
                btnReg.FlatAppearance.BorderSize = 0;
                btnReg.FlatStyle = FlatStyle.Flat;
            }
            catch
            {
                MessageBox.Show(this, text, caption, buttons, icon);
            }
        }
        public int i = 0;
        private void btnAut_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < dgwPolz.RowCount; i++)
                    if (dgwPolz[1, i].FormattedValue.ToString().Contains(tbLog.Text.Trim()))
                    {
                         if (dgwPolz[2, i].FormattedValue.ToString() == tbPass.Text)
                            {
                            TypRed typRed = new TypRed();
                            this.Close();

                            if (typRed.ShowDialog(this) == DialogResult.Cancel)
                                return;
                            } else MessageBox.Show(this, text1, caption, buttons, icon);
                    return;
                    } else MessageBox.Show(this, text1, caption, buttons, icon);
            }
            catch
            {
                MessageBox.Show(this, text1, caption, buttons, icon);
            }
            
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            reg regs = new reg();

            if (regs.ShowDialog(this) == DialogResult.Cancel)
                return;
        }
    }
}
