using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Amal amal = new Amal();
        Arifmetika arifmetika = new Arifmetika();
       
        public void Result(Amal amal)
        {
            switch (amal)
            {
                case Amal.qosh:
                    tbNatija.Text = arifmetika.Qoshish
                        (double.Parse(tbbirinchiSon.Text), double.Parse(tbikkinchiSon.Text)).ToString();
                    break;
                case Amal.ayir:
                    tbNatija.Text = arifmetika.Ayrish
                        (double.Parse(tbbirinchiSon.Text), double.Parse(tbikkinchiSon.Text)).ToString();
                    break;
                case Amal.bol:
                    tbNatija.Text = arifmetika.Bolish
                        (double.Parse(tbbirinchiSon.Text), double.Parse(tbikkinchiSon.Text)).ToString();
                    break;
                case Amal.kopay:
                    tbNatija.Text = arifmetika.Kopaytrish
                        (double.Parse(tbbirinchiSon.Text), double.Parse(tbikkinchiSon.Text)).ToString();
                    break;
                case Amal.cos:
                    tbNatija.Text = arifmetika.Cos().ToString();
                    break;
                case Amal.sin:
                    tbNatija.Text = arifmetika.Sin().ToString();
                    break;
                case Amal.log:
                    tbNatija.Text = arifmetika.Log().ToString();
                    break;
                case Amal.ctg:
                    tbNatija.Text = arifmetika.Ctg().ToString();
                    break;
                case Amal.tg:
                    tbNatija.Text = arifmetika.Tg().ToString();
                    break;
                case Amal.ildiz:
                    tbNatija.Text = arifmetika.Ildiz().ToString();
                    break;
                case Amal.kub:
                    tbNatija.Text = arifmetika.Kub().ToString();
                    break;
                case Amal.kvadrat:
                    tbNatija.Text = arifmetika.Kvadrat().ToString();
                    break;
                default:
                    break;
            }
            tbamal.Text = amal.ToString();
        }

        private void ayir_Click(object sender, EventArgs e)
        {
            Result(Amal.ayir);
        }
        private void qosh_Click(object sender, EventArgs e)
        {
            Result(Amal.qosh);
        }

        private void kopay_Click(object sender, EventArgs e)
        {
            Result(Amal.kopay);
        }

        private void bol_Click(object sender, EventArgs e)
        {
            Result(Amal.bol);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tbKvadrat_Click(object sender, EventArgs e)
        {
            Result(Amal.kvadrat);
        }

        private void btnIldiz_Click(object sender, EventArgs e)
        {
            Result(Amal.ildiz);
        }

        private void btnKub_Click(object sender, EventArgs e)
        {
            Result(Amal.kub);
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            Result(Amal.log);
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            Result(Amal.sin);
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            Result(Amal.cos);
        }

        private void btntg_Click(object sender, EventArgs e)
        {
            Result(Amal.tg);
        }

        private void btnctg_Click(object sender, EventArgs e)
        {
            Result(Amal.ctg);
        }
    }
}
