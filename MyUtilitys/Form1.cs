using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyUtilitys
{
    public partial class MainForm : Form
    {
        int count = 0;
        private Random rnd;
        char[] spec_chars = new char[] {'%','*',')','?','#','!','^','&'};
        private Dictionary<string, double> metrica; 

        public MainForm()
        {
            InitializeComponent();
            rnd = new Random();
            metrica = new Dictionary<string, double>();
            metrica.Add("mm", 1);
            metrica.Add("cm", 10);
            metrica.Add("dm", 100);
            metrica.Add("m", 1000);
            metrica.Add("km", 1e6);
            metrica.Add("mile", 1609344);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа содержит утилиты, которые может пригодится в жизни, а главное научить меня основам программирования на языке C#", "About the programm");
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            count++;
            lblCount.Text = count.ToString();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            count--;
            lblCount.Text = count.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            count = 0;
            lblCount.Text = count.ToString();
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            int n;
            n = rnd.Next(Convert.ToInt32(nudFrom.Value), Convert.ToInt32(nudBefore.Value)+1);
            lblRandom.Text = n.ToString();
            if (cbRepetition.Checked)
            {
                int i = 0;
                while (tbRandom.Text.IndexOf(n.ToString()) != -1)
                {
                    n = rnd.Next(Convert.ToInt32(nudFrom.Value), Convert.ToInt32(nudBefore.Value) + 1);
                    i++;
                    if (i > 1000) break;
                }
                if (i<=1000) tbRandom.AppendText(n + "\n");
            }
            else tbRandom.AppendText(n + "\n");
        }

        private void btnRandomClear_Click(object sender, EventArgs e)
        {
            tbRandom.Clear();
        }

        private void btnRandomCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tbRandom.Text);
        }

        private void tsmiInsertDate_Click(object sender, EventArgs e)
        {
           rtbNotepad.AppendText(DateTime.Now.ToShortDateString()+"\n");
        }

        private void tsmiInsertTime_Click(object sender, EventArgs e)
        {
            rtbNotepad.AppendText(DateTime.Now.ToShortTimeString() + "\n");
        }

        private void tsmiSave_Click (object sender, EventArgs e)
            {
            try
            {
                rtbNotepad.SaveFile("notepad.rtf");
            }
            catch
            {
                MessageBox.Show("Eror. Can't save the file.");
            }}

        void LoadNotebad()
        {
            try
            {
                rtbNotepad.LoadFile("notepad.rtf");
            }
            catch
            {
                MessageBox.Show("Eror. Can't load the file.");
            }
        }

        private void tsmiLoad_Click(object sender, EventArgs e)
        {
            LoadNotebad();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadNotebad();
        }

        private void btnCreatePassword_Click(object sender, EventArgs e)
        {
            if (clbPasswordType.CheckedItems.Count==0) return;
            string password = "";
            for (int i = 0; i < nudPasswordLenght.Value; i++)
            {
                int n = rnd.Next(0, clbPasswordType.CheckedItems.Count);
                string s = clbPasswordType.CheckedItems[n].ToString();
                switch (s)
                {
                    case "Цифры":
                        password += rnd.Next(10).ToString();
                        break;
                    case "Прописные буквы":
                        password += Convert.ToChar(rnd.Next(65, 88));
                        break;
                    case "Строчные буквы":
                        password += Convert.ToChar(rnd.Next(97, 122));
                        break;
                    default:
                        password += spec_chars[rnd.Next(spec_chars.Length)];
                        break;
                }
                tbPassword.Text = password;
            }
        }

        private void btnCopyPassword_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tbPassword.Text);
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            double m1 = metrica[cbConvertFrom.Text];
            double m2 = metrica[cbConvertTo.Text];
            double n = Convert.ToDouble(tbConvertFrom.Text);
            tbConvertTo.Text = (n*m1/m2).ToString();

        }

        private void btnSwap_Click(object sender, EventArgs e)
        {
            string t = cbConvertFrom.Text;
            cbConvertFrom.Text = cbConvertTo.Text;
            cbConvertTo.Text = t;
        }

        private void cbMetric_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbMetric.Text)
            {
                case "Lenght":
                    metrica.Clear();
                    metrica.Add("mm", 1);
                    metrica.Add("cm", 10);
                    metrica.Add("dm", 100);
                    metrica.Add("m", 1000);
                    metrica.Add("km", 1e6);
                    metrica.Add("mile", 1609344);
                    cbConvertFrom.Items.Clear();
                    cbConvertFrom.Items.Add("mm");
                    cbConvertFrom.Items.Add("cm");
                    cbConvertFrom.Items.Add("dm");
                    cbConvertFrom.Items.Add("m");
                    cbConvertFrom.Items.Add("km");
                    cbConvertFrom.Items.Add("mile");
                    cbConvertTo.Items.Clear();
                    cbConvertTo.Items.Add("mm");
                    cbConvertTo.Items.Add("cm");
                    cbConvertTo.Items.Add("dm");
                    cbConvertTo.Items.Add("m");
                    cbConvertTo.Items.Add("km");
                    cbConvertTo.Items.Add("mile");
                    cbConvertFrom.Text = "mm";
                    cbConvertTo.Text = "mm";
                    break;
                case "Weight":
                    metrica.Clear();
                    metrica.Add("g", 1);
                    metrica.Add("kg", 1000);
                    metrica.Add("t", 1e9);
                    metrica.Add("lb", 453.6);
                    metrica.Add("oz", 283);
                    cbConvertFrom.Items.Clear();
                    cbConvertFrom.Items.Add("g");
                    cbConvertFrom.Items.Add("kg");
                    cbConvertFrom.Items.Add("t");
                    cbConvertFrom.Items.Add("lb");
                    cbConvertFrom.Items.Add("oz");
                    cbConvertTo.Items.Clear();
                    cbConvertTo.Items.Add("g");
                    cbConvertTo.Items.Add("kg");
                    cbConvertTo.Items.Add("t");
                    cbConvertTo.Items.Add("lb");
                    cbConvertTo.Items.Add("oz");
                    cbConvertFrom.Text = "g";
                    cbConvertTo.Text = "g";
                    break;
            }

        }

        //private void tsmiAutoSave_Click(object sender, EventArgs e)
        //{
        //    if (tsmiAutoSave.Checked == true)
        //    {
        //        time = Stopwatch.StartNew();
        //    }
        //}
    }
}
