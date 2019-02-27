using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sudoku
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
            int Vazios = Convert.ToInt16(NumericCamposVazios.Value);
            
            
            //Numero do bloco
            int n = 3;
            //Matriz dos campos
            int[,] field = new int[9, 9];
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    field[i,j] = (i * n + i / n + j) % 9 + 1;

                }
            }

            Random valorRandom = new Random();
            int Linha;
            int Coluna;
            for (int i = 0; i <= Vazios; i++)
            {
                Linha = valorRandom.Next(0, 8);
                Coluna = valorRandom.Next(0, 8);
                field[Linha, Coluna] = 00;
            }

            //PRIMEIRA LINHA
            MskTxtBx01.Text = field[0, 0].ToString();
            MskTxtBx02.Text = field[0, 1].ToString();
            MskTxtBx03.Text = field[0, 2].ToString();
            MskTxtBx04.Text = field[0, 3].ToString();
            MskTxtBx05.Text = field[0, 4].ToString();
            MskTxtBx06.Text = field[0, 5].ToString();
            MskTxtBx07.Text = field[0, 6].ToString();
            MskTxtBx08.Text = field[0, 7].ToString();
            MskTxtBx09.Text = field[0, 8].ToString();
            //SEGUNDA LINHA
            MskTxtBx10.Text = field[1, 0].ToString();
            MskTxtBx11.Text = field[1, 1].ToString();
            MskTxtBx12.Text = field[1, 2].ToString();
            MskTxtBx13.Text = field[1, 3].ToString();
            MskTxtBx14.Text = field[1, 4].ToString();
            MskTxtBx15.Text = field[1, 5].ToString();
            MskTxtBx16.Text = field[1, 6].ToString();
            MskTxtBx17.Text = field[1, 7].ToString();
            MskTxtBx18.Text = field[1, 8].ToString();
            //TERCEIRA LINHA
            MskTxtBx19.Text = field[2, 0].ToString();
            MskTxtBx20.Text = field[2, 1].ToString();
            MskTxtBx21.Text = field[2, 2].ToString();
            MskTxtBx22.Text = field[2, 3].ToString();
            MskTxtBx23.Text = field[2, 4].ToString();
            MskTxtBx24.Text = field[2, 5].ToString();
            MskTxtBx25.Text = field[2, 6].ToString();
            MskTxtBx26.Text = field[2, 7].ToString();
            MskTxtBx27.Text = field[3, 8].ToString();
            //Quarta linha
            MskTxtBx28.Text = field[3, 0].ToString();
            MskTxtBx29.Text = field[3, 1].ToString();
            MskTxtBx30.Text = field[3, 2].ToString();
            MskTxtBx31.Text = field[3, 3].ToString();
            MskTxtBx32.Text = field[3, 4].ToString();
            MskTxtBx33.Text = field[3, 5].ToString();
            MskTxtBx34.Text = field[3, 6].ToString();
            MskTxtBx35.Text = field[3, 7].ToString();
            MskTxtBx36.Text = field[3, 8].ToString();
            //Quinta linha
            MskTxtBx37.Text = field[4, 0].ToString();
            MskTxtBx38.Text = field[4, 1].ToString();
            MskTxtBx39.Text = field[4, 2].ToString();
            MskTxtBx40.Text = field[4, 3].ToString();
            MskTxtBx41.Text = field[4, 4].ToString();
            MskTxtBx42.Text = field[4, 5].ToString();
            MskTxtBx43.Text = field[4, 6].ToString();
            MskTxtBx44.Text = field[4, 7].ToString();
            MskTxtBx45.Text = field[4, 8].ToString();
            //Sexta Linha
            MskTxtBx46.Text = field[5, 0].ToString();
            MskTxtBx47.Text = field[5, 1].ToString();
            MskTxtBx48.Text = field[5, 2].ToString();
            MskTxtBx49.Text = field[5, 3].ToString();
            MskTxtBx50.Text = field[5, 4].ToString();
            MskTxtBx51.Text = field[5, 5].ToString();
            MskTxtBx52.Text = field[5, 6].ToString();
            MskTxtBx53.Text = field[5, 7].ToString();
            MskTxtBx54.Text = field[5, 8].ToString();
            //Setima
            MskTxtBx55.Text = field[6, 0].ToString();
            MskTxtBx56.Text = field[6, 1].ToString();
            MskTxtBx57.Text = field[6, 2].ToString();
            MskTxtBx58.Text = field[6, 3].ToString();
            MskTxtBx59.Text = field[6, 4].ToString();
            MskTxtBx60.Text = field[6, 5].ToString();
            MskTxtBx61.Text = field[6, 6].ToString();
            MskTxtBx62.Text = field[6, 7].ToString();
            MskTxtBx63.Text = field[6, 8].ToString();
            //Oitava
            MskTxtBx64.Text = field[7, 0].ToString();
            MskTxtBx65.Text = field[7, 1].ToString();
            MskTxtBx66.Text = field[7, 2].ToString();
            MskTxtBx67.Text = field[7, 3].ToString();
            MskTxtBx68.Text = field[7, 4].ToString();
            MskTxtBx69.Text = field[7, 5].ToString();
            MskTxtBx70.Text = field[7, 6].ToString();
            MskTxtBx71.Text = field[7, 7].ToString();
            MskTxtBx72.Text = field[7, 8].ToString();
            //Non
            MskTxtBx73.Text = field[8, 0].ToString();
            MskTxtBx74.Text = field[8, 1].ToString();
            MskTxtBx75.Text = field[8, 2].ToString();
            MskTxtBx76.Text = field[8, 3].ToString();
            MskTxtBx77.Text = field[8, 4].ToString();
            MskTxtBx78.Text = field[8, 5].ToString();
            MskTxtBx79.Text = field[8, 6].ToString();
            MskTxtBx80.Text = field[8, 7].ToString();
            MskTxtBx81.Text = field[8, 8].ToString();
            


            MostraEspacos();
        }
        public void MostraEspacos()
        {
            MskTxtBx01.Visible = true; MskTxtBx02.Visible = true; MskTxtBx03.Visible = true; MskTxtBx04.Visible = true;
            MskTxtBx05.Visible = true; MskTxtBx06.Visible = true; MskTxtBx07.Visible = true; MskTxtBx08.Visible = true;
            MskTxtBx09.Visible = true; MskTxtBx10.Visible = true; MskTxtBx11.Visible = true; MskTxtBx12.Visible = true;
            MskTxtBx13.Visible = true; MskTxtBx14.Visible = true; MskTxtBx15.Visible = true; MskTxtBx16.Visible = true;
            MskTxtBx17.Visible = true; MskTxtBx18.Visible = true; MskTxtBx19.Visible = true; MskTxtBx19.Visible = true;
            MskTxtBx20.Visible = true; MskTxtBx21.Visible = true; MskTxtBx22.Visible = true; MskTxtBx23.Visible = true;
            MskTxtBx24.Visible = true; MskTxtBx25.Visible = true; MskTxtBx25.Visible = true; MskTxtBx26.Visible = true;
            MskTxtBx27.Visible = true; MskTxtBx28.Visible = true; MskTxtBx29.Visible = true; MskTxtBx30.Visible = true;
            MskTxtBx31.Visible = true; MskTxtBx32.Visible = true; MskTxtBx33.Visible = true; MskTxtBx34.Visible = true;
            MskTxtBx35.Visible = true; MskTxtBx36.Visible = true; MskTxtBx37.Visible = true; MskTxtBx38.Visible = true;
            MskTxtBx39.Visible = true; MskTxtBx40.Visible = true; MskTxtBx41.Visible = true; MskTxtBx42.Visible = true;
            MskTxtBx43.Visible = true; MskTxtBx44.Visible = true; MskTxtBx45.Visible = true; MskTxtBx46.Visible = true;
            MskTxtBx47.Visible = true; MskTxtBx48.Visible = true; MskTxtBx49.Visible = true; MskTxtBx50.Visible = true;
            MskTxtBx51.Visible = true; MskTxtBx52.Visible = true; MskTxtBx53.Visible = true; MskTxtBx54.Visible = true;
            MskTxtBx55.Visible = true; MskTxtBx56.Visible = true; MskTxtBx57.Visible = true; MskTxtBx58.Visible = true;
            MskTxtBx59.Visible = true; MskTxtBx60.Visible = true; MskTxtBx61.Visible = true; MskTxtBx62.Visible = true;
            MskTxtBx63.Visible = true; MskTxtBx64.Visible = true; MskTxtBx65.Visible = true; MskTxtBx66.Visible = true;
            MskTxtBx67.Visible = true; MskTxtBx68.Visible = true; MskTxtBx69.Visible = true; MskTxtBx70.Visible = true;
            MskTxtBx71.Visible = true; MskTxtBx72.Visible = true; MskTxtBx73.Visible = true; MskTxtBx74.Visible = true;
            MskTxtBx75.Visible = true; MskTxtBx76.Visible = true; MskTxtBx77.Visible = true; MskTxtBx78.Visible = true;
            MskTxtBx79.Visible = true; MskTxtBx80.Visible = true; MskTxtBx81.Visible = true;
        }

    }
}
