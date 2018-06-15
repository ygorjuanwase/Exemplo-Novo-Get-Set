using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Time times = new Time(txtNome.Text, txtPais.Text, txtserie.Text,)
                {
                    Faturamento = Convert.ToDecimal(txtFaturamento.Text)
                };    
        }

       

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Time time = new Time(txtNome.Text, txtPais.Text);
        }
    }
}
