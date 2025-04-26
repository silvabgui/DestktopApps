using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Cinemark
{
    public partial class Form1 : Form
    {
        Button[,] b = new Button[10, 20];
        char letra = 'A';
        int ocupadas = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    b[i, j] = new Button();
                    b[i, j].Name = "Botão " + (i + 1);
                    b[i, j].Text = letra + "" + (j + 1);
                    b[i, j].Location = new Point(100 + j * 80, 60 + i * 60);
                    b[i, j].BackColor = Color.Green;
                    b[i, j].ForeColor = Color.White;
                    b[i, j].Size = new Size(76, 57);
                    Controls.Add(b[i, j]);
                    b[i, j].Click += metodoGenerico;
                }
                letra++;
            }
        }

        private void metodoGenerico(object sender, EventArgs e)
        {
            Button aux = (Button)sender;
            if (aux.BackColor == Color.Green)
            {
                DialogResult BoxResponse = MessageBox.Show(
                    "Deseja selecionar a Poltrona " + aux.Text + "?",
                    "Confirmação",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (BoxResponse == DialogResult.Yes)
                {
                    aux.BackColor = Color.Red;
                    ++ocupadas;
                }
            }

            else if (aux.BackColor == Color.Red)
            {

                DialogResult boxResponse = MessageBox.Show(
                    "Deseja cancelar a reserva ?",
                    "Confirmação",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                aux.BackColor = Color.Green;
                --ocupadas;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int vlrTotal = ocupadas * 20;
            MessageBox.Show("Valor Total: R$ " + vlrTotal, "Ingresso(s)");
        }
    }
}
