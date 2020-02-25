using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConteudoIfElse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int A1;
            int B1;

            A1 = 200;
            B1 = 100;


            if(A1 > B1)
            {
                listBoxExemplo.Items.Add(A1 +" é menor que "+ B1);
            }
            listBoxExemplo.Items.Add(new string('_', 30));

            listBoxExemplo.Items.Add("Exemplo 2");

            A1 = 10;
            B1 = 23;

            if (A1 < B1)
            {
                listBoxExemplo.Items.Add(A1 + " é menor que " + B1);
            }

        }

        private void limparListBox()
        {
            listBoxExemplo.Items.Clear();
        }

        private void Sairaplicativo()
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            limparListBox();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Sairaplicativo();
        }
    }
}
