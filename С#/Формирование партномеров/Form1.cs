using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInt_Click(object sender, EventArgs e)
        {
            if (cbKorpInt.Text.Length >0 && cbKanInt.Text.Length > 0 && cbDiapInt.Text.Length > 0 && cbOprosInt.Text.Length > 0 && cbTipKonInt.Text.Length > 0 && cbVolInt.Text.Length > 0)
            {
                tbPartInt.Text = "IS-A3";

                if (cbKorpInt.Text == "19, 2U/220AC")
                {
                    tbPartInt.Text += "1";
                }
                else if (cbKorpInt.Text == "mini/24В")
                {
                    tbPartInt.Text += "2";
                }
                else tbPartInt.Text += "3";

                if (cbKanInt.Text == "1")
                {
                    tbPartInt.Text += "0";
                }
                else if (cbKanInt.Text == "2")
                {
                    tbPartInt.Text += "1";
                }
                else if (cbKanInt.Text == "4")
                {
                    tbPartInt.Text += "2";
                }
                else tbPartInt.Text += "3";

                if (cbDiapInt.Text == "80 нм")
                {
                    tbPartInt.Text += "-080";
                }
                else if (cbDiapInt.Text == "100 нм")
                {
                    tbPartInt.Text += "-100";
                }
                else tbPartInt.Text += "-000";

                if (cbOprosInt.Text == "5Гц")
                {
                    tbPartInt.Text += "-005";
                }
                else if (cbOprosInt.Text == "100Гц")
                {
                    tbPartInt.Text += "-100";
                }
                else tbPartInt.Text += "-001";

                if (cbTipKonInt.Text == "FC/APC")
                {
                    tbPartInt.Text += "-FC";
                }
                else if (cbTipKonInt.Text == "SC/APC")
                {
                    tbPartInt.Text += "-SC";
                }
                else tbPartInt.Text += "-E2";

                if (cbVolInt.Text == "Одномодовое")
                {
                    tbPartInt.Text += "-SM";
                }
                else tbPartInt.Text += "-MM";
            }
            else MessageBox.Show("Заполнены не все параметры", "Ошибка!", MessageBoxButtons.OKCancel);

            if (cbKorpInt.Enabled == false)
            {
                btnMD.PerformClick();
            }
        }

        private void btnMD_Click(object sender, EventArgs e)
        {
            if (cbKorpMD.Text.Length > 0 && cbKonVhMD.Text.Length > 0 && cbKonVihMD.Text.Length > 0 && cbPoMD.Text.Length > 0 && cbTipKonVhMD.Text.Length > 0 && cbTipKonVihMD.Text.Length > 0)
            {
                tbPartMD.Text = "IS-MD";

                if (cbKorpMD.Text == "Отсутствует")
                {
                    tbPartMD.Text += "0";
                } else tbPartMD.Text += "1";

                if (cbKonVhMD.Text == "1")
                {
                    tbPartMD.Text += "1";
                }else tbPartMD.Text += "4";

                if (cbKonVihMD.Text == "1")
                {
                    tbPartMD.Text += "-0";
                }
                else if (cbKonVihMD.Text == "2")
                {
                    tbPartMD.Text += "-1";
                }
                else if (cbKonVihMD.Text == "4")
                {
                    tbPartMD.Text += "-2";
                }
                else tbPartMD.Text += "-3";

                if (cbPoMD.Text == "СКД")
                {
                    tbPartMD.Text += "-S";
                }
                else if (cbPoMD.Text == "ММАСВОД")
                {
                    tbPartMD.Text += "-M";
                }
                else tbPartMD.Text += "-A";

                if (cbTipKonVhMD.Text == "Голое волокно")
                {
                    tbPartMD.Text += "0";
                }
                else if (cbTipKonVhMD.Text == "FC/APC")
                {
                    tbPartMD.Text += "1";
                }
                else if (cbTipKonVhMD.Text == "SC/APC")
                {
                    tbPartMD.Text += "2";
                }
                else if (cbTipKonVhMD.Text == "SKD")
                {
                    tbPartMD.Text += "2";
                }
                else tbPartMD.Text += "4";

                if (cbTipKonVihMD.Text == "Голое волокно")
                {
                    tbPartMD.Text += "0";
                }
                else if (cbTipKonVihMD.Text == "FC/APC")
                {
                    tbPartMD.Text += "1";
                }
                else if (cbTipKonVihMD.Text == "SC/APC")
                {
                    tbPartMD.Text += "2";
                }
                else if (cbTipKonVihMD.Text == "SKD")
                {
                    tbPartMD.Text += "2";
                }
                else tbPartMD.Text += "4";

            }
            else MessageBox.Show("Заполнены не все параметры", "Ошибка!", MessageBoxButtons.OKCancel);
        }

        private void btnPL_Click(object sender, EventArgs e)
        {
            if (cbKorpPL.Text.Length > 0 && cbKonPL.Text.Length > 0 && cbDiapPL.Text.Length > 0 && cbPoPL.Text.Length > 0 && cbFiltPL.Text.Length > 0 && cbTipKonPL.Text.Length > 0)
            {
                tbPartPL.Text = "IS-PL";

                if (cbKorpPL.Text == "Отсутствует")
                {
                    tbPartPL.Text += "0";
                }
                else tbPartPL.Text += "1";

                if (cbKonPL.Text == "1")
                {
                    tbPartPL.Text += "1";
                }
                else if (cbKonPL.Text == "2")
                {
                    tbPartPL.Text += "2";
                }
                else tbPartPL.Text += "4";

                if (cbDiapPL.Text == "80")
                {
                    tbPartPL.Text += "-0";
                }
                else if (cbDiapPL.Text == "100")
                {
                    tbPartPL.Text += "-1";
                }
                else tbPartPL.Text += "-2";

                if (cbPoPL.Text == "СКД")
                {
                    tbPartPL.Text += "-S";
                }
                else if (cbPoPL.Text == "ММАСВОД")
                {
                    tbPartPL.Text += "-M";
                }
                else tbPartPL.Text += "-A";

                if (cbFiltPL.Text == "HBMFS")
                {
                    tbPartPL.Text += "0";
                }
                else tbPartPL.Text += "1";

                if (cbTipKonPL.Text == "Голое волокно")
                {
                    tbPartPL.Text += "0";
                }
                else if (cbTipKonPL.Text == "FC/APC")
                {
                    tbPartPL.Text += "1";
                }
                else tbPartPL.Text += "2";

            }
            else MessageBox.Show("Заполнены не все параметры", "Ошибка!", MessageBoxButtons.OKCancel);
        }

        private void cbVolInt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbVolInt.Text == "Многомодовое") 
            {
                cbKorpInt.SelectedItem = "19, 2U/220AC";
                cbKanInt.SelectedItem = "4";
                cbDiapInt.SelectedItem = "100 нм";
                cbOprosInt.SelectedItem = "5Гц";
                cbTipKonInt.SelectedItem = "E2000/APC";
                cbKorpInt.Enabled = false;
                cbKanInt.Enabled = false;
                cbDiapInt.Enabled = false;
                cbOprosInt.Enabled = false;
                cbTipKonInt.Enabled = false;

                cbKorpMD.Text = "Отсутствует";
                cbKonVhMD.Text = "4";
                cbKonVihMD.Text = "4";
                cbPoMD.Text = "ММАСВОД";
                cbTipKonVhMD.Text = "FC/APC";
                cbTipKonVihMD.Text = "E2000/APC";
                cbKorpMD.Enabled = false;
                cbKonVhMD.Enabled = false;
                cbKonVihMD.Enabled = false;
                cbPoMD.Enabled = false;
                cbTipKonVhMD.Enabled = false;
                cbTipKonVihMD.Enabled = false;

                cbKorpPL.Text = "Отсутствует";
                cbKonPL.Text = "4";
                cbDiapPL.Text = "100";
                cbPoPL.Text = "ММАСВОД";
                cbTipKonPL.Text = "Голое волокно";
                cbKorpPL.Enabled = false;
                cbKonPL.Enabled = false;
                cbDiapPL.Enabled = false;
                cbPoPL.Enabled = false;
                cbTipKonPL.Enabled = false;
                btnInt.PerformClick();
            }
            else
            {
                cbKorpInt.Enabled = true;
                cbKanInt.Enabled = true;
                cbDiapInt.Enabled = true;
                cbOprosInt.Enabled = true;
                cbTipKonInt.Enabled = true;

                cbKorpMD.Enabled = true;
                cbKonVhMD.Enabled = true;
                cbKonVihMD.Enabled = true;
                cbPoMD.Enabled = true;
                cbTipKonVhMD.Enabled = true;
                cbTipKonVihMD.Enabled = true;

                cbKorpPL.Enabled = true;
                cbKonPL.Enabled = true;
                cbDiapPL.Enabled = true;
                cbPoPL.Enabled = true;
                cbTipKonPL.Enabled = true;
            }
        }

        private void cbFiltPL_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbKorpInt.Enabled == false)
            {
                btnPL.PerformClick();
            }
        }

        private void cbDiapInt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDiapInt.Text == "80 нм")
            {
                cbDiapPL.Text = "80";
            }
            else if (cbDiapInt.Text == "100 нм")
            {
                cbDiapPL.Text = "100";
            }
            else
            {
                cbDiapPL.Text = "Настраиваемый";
            }
        }

        private void cbKanInt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbKanInt.Text == "1")
            {
                cbKonVihMD.Text = "1";
            } else if (cbKanInt.Text == "2")
            {
                cbKonVihMD.Text = "2";
            }else if (cbKanInt.Text == "4")
            {
                cbKonVihMD.Text = "4";
            } else cbKonVihMD.Text = "8";
        }

        private void cbOprosInt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbOprosInt.Text == "1Гц")
            {
                cbPoMD.Text = "АСВОД";
                cbPoPL.Text = "АСВОД";
                cbKonPL.Text = "1";
                cbKonVhMD.Text = "1";
                cbVolInt.Text = "Одномодовое";
                cbTipKonVhMD.Text = "FC/APC";
                cbTipKonPL.Text = "FC/APC";
                cbTipKonPL.Enabled = false;
                cbVolInt.Enabled = false;
                cbTipKonVhMD.Enabled = false;
                cbKonVhMD.Enabled = false;
                cbKonPL.Enabled = false;
                cbPoPL.Enabled = false;
                cbPoMD.Enabled = false;
            } else
            {
                cbTipKonPL.Enabled = true;
                cbVolInt.Enabled = true;
                cbTipKonVhMD.Enabled = true;
                cbKonVhMD.Enabled = true;
                cbKonPL.Enabled = true;
                cbPoPL.Enabled = true;
                cbPoMD.Enabled = true;
            }
        }

        private void cbTipKonInt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTipKonInt.Text == "FC/APC")
            {
                cbTipKonVihMD.Text = "FC/APC";
            } else if (cbTipKonInt.Text == "SC/APC")
            {
                cbTipKonVihMD.Text = "SC/APC";
            } else cbTipKonVihMD.Text = "E2000/APC";
        }

        private void btnClint_Click(object sender, EventArgs e)
        {
            cbKorpInt.SelectedIndex = -1;
            cbKanInt.SelectedIndex = -1;
            cbDiapInt.SelectedIndex = -1;
            cbOprosInt.SelectedIndex = -1;
            cbTipKonInt.SelectedIndex = -1;
            cbVolInt.SelectedIndex = -1;
            tbPartInt.Text = "";

        }

        private void btnClMD_Click(object sender, EventArgs e)
        {
            cbKorpMD.SelectedIndex = -1;
            cbKonVhMD.SelectedIndex = -1;
            cbKonVihMD.SelectedIndex = -1;
            cbPoMD.SelectedIndex = -1;
            cbTipKonVhMD.SelectedIndex = -1;
            cbTipKonVihMD.SelectedIndex = -1;
            tbPartMD.Text = "";
        }

        private void btnClPL_Click(object sender, EventArgs e)
        {
            cbKorpPL.SelectedIndex = -1;
            cbKonPL.SelectedIndex = -1;
            cbDiapPL.SelectedIndex = -1;
            cbPoPL.SelectedIndex = -1;
            cbTipKonPL.SelectedIndex = -1;
            cbFiltPL.SelectedIndex = -1;
            tbPartPL.Text = "";
        }

        private void cbKonVhMD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbKonVhMD.Text == "1")
            {
                cbKonPL.Text = "1";
            } else cbKonPL.Text = "4";
        }

        private void cbKonPL_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbKonPL.Text == "1")
            {
                if (cbKonVhMD.Text != "1") { cbKonVhMD.Text = "1"; }
            } else 
                if (cbKonPL.Text == "4")
                {
                if (cbKonVhMD.Text != "4") { cbKonVhMD.Text = "4"; }
                }
        }
    }
}
