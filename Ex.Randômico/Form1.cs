using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex.Randômico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            lsbRand.Items.Clear();
            lsbSequ.Items.Clear();

            int[] valores = new int[10];
            Random random = new Random();

            for (int i = 0; i < valores.Length; i++)
            {
                valores[i] = random.Next(1, 101);
            }

            foreach (int valor in valores)
            {
                lsbRand.Items.Add(valor);
            }

            Array.Sort(valores);

            foreach (int valor in valores)
            {
                lsbSequ.Items.Add(valor);
            }
        }
    }
}
