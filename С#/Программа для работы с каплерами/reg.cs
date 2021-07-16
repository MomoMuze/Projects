using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using infSis.Model;
using Microsoft.EntityFrameworkCore;


namespace infSis
{
    public partial class reg : Form
    {
        infSisContext db;
        string text = "Ошибка подключения к БД";
        string caption = "Ошибка";
        string text1 = "Успешно";
        string caption1 = "Успешно";
        MessageBoxButtons buttons = MessageBoxButtons.OK;
        MessageBoxIcon icon = MessageBoxIcon.Error;
        public reg()
        {
            InitializeComponent();
            db = new infSisContext();
            try
            {
                db.Pozls.Load();
            }
            catch
            {
                MessageBox.Show(this, text, caption, buttons, icon);
            }
        }

        private void btnAut_Click(object sender, EventArgs e)
        {
            try
            {
                Pozl polz = new Pozl();
                polz.Log = tbLog.Text;
                polz.Pass = tbPass.Text;
                db.Pozls.Add(polz);
                db.SaveChanges();
                MessageBox.Show(this, text1, caption1, buttons);
                this.Close();
            }
            catch
            {
                MessageBox.Show(this, text, caption, buttons, icon);
            }
            
            
        }
    }
}
