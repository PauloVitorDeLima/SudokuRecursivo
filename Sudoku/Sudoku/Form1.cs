using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            int num = 3;
            //Matriz dos campos

            // PRIMEIRA MANEIRA DE FAZER: 
                int[,] field = new int[9, 9];
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    field[i,j] = (i * num + i / num + j) % 9 + 1;
                }
            }
            //SEGUNDA MANEIRA DE FAZER:

            int Elemento = 3;//aqui vai o numero de elementos do seu sudoku(3 vai ser um sudoku 3x3
            //int[][] field = new int[n * n][n * n];//matriz onde será armazenado o sudoku
            Random numeroAleatorio = new Random();
            int Aleatorio = numeroAleatorio.Next(0,10); //semente aleatória para não gerar o mesmo sudoku
            for (int bloco = 0; bloco < Elemento; bloco++, Aleatorio++)
            {
                for (int linha = 0; linha < Elemento; linha++, Aleatorio += Elemento)
                {
                    for (int col = 0; col < Elemento * Elemento; col++, Aleatorio++)
                    {
                        field[Elemento * bloco + linha, col] = (Aleatorio % (Elemento * Elemento)) + 1;
                    }
                }
            }



            //Cria valor aleatório
            Random valorRandom = new Random();
            int Linha;
            int Coluna;
            //
            for (int i = 0; i < Vazios; i++)
            {
                Linha = valorRandom.Next(0, 8);
                Coluna = valorRandom.Next(0, 8);
                field[Linha,Coluna] = 0;
            }


            MostraEspacosAsync();
            AdicionaValoresAsync(field);
            
        }
         public void AdicionaValores(MaskedTextBox box, int valor)
        {
            if (valor == 0)
            {
                box.Text = null;
            }
            else
            {
                box.Text = valor.ToString();
            }
        }
            
        public async void AdicionaValoresAsync(int[,]field)
        {

            //PRIMEIRA LINHA
            await Task.Delay(300);
            AdicionaValores(MskTxtBx00, field[0,0]); AdicionaValores(MskTxtBx01, field[0, 1]); AdicionaValores(MskTxtBx02, field[0, 2]); AdicionaValores(MskTxtBx03, field[0, 3]);
            AdicionaValores(MskTxtBx04, field[0, 4]); AdicionaValores(MskTxtBx05, field[0, 5]); AdicionaValores(MskTxtBx06, field[0, 6]); AdicionaValores(MskTxtBx07, field[0, 7]);
            AdicionaValores(MskTxtBx08, field[0, 8]);
            //SEGUNDA LINHA
            await Task.Delay(300);
            AdicionaValores(MskTxtBx10, field[1, 0]); AdicionaValores(MskTxtBx11, field[1, 1]); AdicionaValores(MskTxtBx12, field[1, 2]); AdicionaValores(MskTxtBx13, field[1, 3]);
            AdicionaValores(MskTxtBx14, field[1, 4]); AdicionaValores(MskTxtBx15, field[1, 5]); AdicionaValores(MskTxtBx16, field[1, 6]); AdicionaValores(MskTxtBx17, field[1, 7]);
            AdicionaValores(MskTxtBx18, field[1, 8]);
            //TERCEIRA LINHA
            await Task.Delay(300);
            AdicionaValores(MskTxtBx20, field[2, 0]); AdicionaValores(MskTxtBx21, field[2, 1]); AdicionaValores(MskTxtBx22, field[2, 2]); AdicionaValores(MskTxtBx23, field[2, 3]);
            AdicionaValores(MskTxtBx24, field[2, 4]); AdicionaValores(MskTxtBx25, field[2, 5]); AdicionaValores(MskTxtBx26, field[2, 6]); AdicionaValores(MskTxtBx27, field[2, 7]);
            AdicionaValores(MskTxtBx28, field[2, 8]);
            //QUARTA LINHA
            await Task.Delay(300);
            AdicionaValores(MskTxtBx30, field[3, 0]); AdicionaValores(MskTxtBx31, field[3, 1]); AdicionaValores(MskTxtBx32, field[3, 2]); AdicionaValores(MskTxtBx33, field[3, 3]);
            AdicionaValores(MskTxtBx34, field[3, 4]); AdicionaValores(MskTxtBx35, field[3, 5]); AdicionaValores(MskTxtBx36, field[3, 6]); AdicionaValores(MskTxtBx37, field[3, 7]);
            AdicionaValores(MskTxtBx38, field[3, 8]);
            //QUINTA LINHA
            await Task.Delay(300);
            AdicionaValores(MskTxtBx40, field[4, 0]); AdicionaValores(MskTxtBx41, field[4, 1]); AdicionaValores(MskTxtBx42, field[4, 2]); AdicionaValores(MskTxtBx43, field[4, 3]);
            AdicionaValores(MskTxtBx44, field[4, 4]); AdicionaValores(MskTxtBx45, field[4, 5]); AdicionaValores(MskTxtBx46, field[4, 6]); AdicionaValores(MskTxtBx47, field[4, 7]);
            AdicionaValores(MskTxtBx48, field[4, 8]);
            //SEXTA LINHA
            await Task.Delay(300);
            AdicionaValores(MskTxtBx50, field[5, 0]); AdicionaValores(MskTxtBx51, field[5, 1]); AdicionaValores(MskTxtBx52, field[5, 2]); AdicionaValores(MskTxtBx53, field[5, 3]);
            AdicionaValores(MskTxtBx54, field[5, 4]); AdicionaValores(MskTxtBx55, field[5, 5]); AdicionaValores(MskTxtBx56, field[5, 6]); AdicionaValores(MskTxtBx57, field[5, 7]);
            AdicionaValores(MskTxtBx58, field[5, 8]);
            //SETIMA LINHA
            await Task.Delay(300);
            AdicionaValores(MskTxtBx60, field[6, 0]); AdicionaValores(MskTxtBx61, field[6, 1]); AdicionaValores(MskTxtBx62, field[6, 2]); AdicionaValores(MskTxtBx63, field[6, 3]);
            AdicionaValores(MskTxtBx64, field[6, 4]); AdicionaValores(MskTxtBx65, field[6, 5]); AdicionaValores(MskTxtBx66, field[6, 6]); AdicionaValores(MskTxtBx67, field[6, 7]);
            AdicionaValores(MskTxtBx68, field[6, 8]);
            //OITAVA LINHA
            await Task.Delay(300);
            AdicionaValores(MskTxtBx70, field[7, 0]); AdicionaValores(MskTxtBx71, field[7, 1]); AdicionaValores(MskTxtBx72, field[7, 2]); AdicionaValores(MskTxtBx73, field[7, 3]);
            AdicionaValores(MskTxtBx74, field[7, 4]); AdicionaValores(MskTxtBx75, field[7, 5]); AdicionaValores(MskTxtBx76, field[7, 6]); AdicionaValores(MskTxtBx77, field[7, 7]);
            AdicionaValores(MskTxtBx78, field[7, 8]);
            //NONA LINHA
            await Task.Delay(300);
            AdicionaValores(MskTxtBx80, field[8, 0]); AdicionaValores(MskTxtBx81, field[8, 1]); AdicionaValores(MskTxtBx82, field[8, 2]); AdicionaValores(MskTxtBx83, field[8, 3]);
            AdicionaValores(MskTxtBx84, field[8, 4]); AdicionaValores(MskTxtBx85, field[8, 5]); AdicionaValores(MskTxtBx86, field[8, 6]); AdicionaValores(MskTxtBx87, field[8, 7]);
            AdicionaValores(MskTxtBx88, field[8, 8]);
        }
        public async void MostraEspacosAsync()
        {
            //PRIMEIRA LINHA
            await Task.Delay(20);
            MskTxtBx00.Visible = true; MskTxtBx01.Visible = true; MskTxtBx02.Visible = true; MskTxtBx03.Visible = true;
            MskTxtBx04.Visible = true; MskTxtBx05.Visible = true; MskTxtBx06.Visible = true; MskTxtBx07.Visible = true;
            MskTxtBx08.Visible = true;
            //SEGUNDA
            await Task.Delay(20);
            MskTxtBx10.Visible = true; MskTxtBx11.Visible = true; MskTxtBx12.Visible = true; MskTxtBx13.Visible = true;
            MskTxtBx14.Visible = true; MskTxtBx15.Visible = true; MskTxtBx16.Visible = true; MskTxtBx17.Visible = true;
            MskTxtBx18.Visible = true;
            //TERCEIRA
            await Task.Delay(20);
            MskTxtBx20.Visible = true; MskTxtBx21.Visible = true; MskTxtBx22.Visible = true; MskTxtBx23.Visible = true;
            MskTxtBx24.Visible = true; MskTxtBx25.Visible = true; MskTxtBx26.Visible = true; MskTxtBx27.Visible = true;
            MskTxtBx28.Visible = true;
            //QUARTA
            await Task.Delay(20);
            MskTxtBx30.Visible = true; MskTxtBx31.Visible = true; MskTxtBx32.Visible = true; MskTxtBx33.Visible = true;
            MskTxtBx34.Visible = true; MskTxtBx35.Visible = true; MskTxtBx36.Visible = true; MskTxtBx37.Visible = true;
            MskTxtBx38.Visible = true;
            //Quinta
            await Task.Delay(20);
            MskTxtBx40.Visible = true; MskTxtBx41.Visible = true; MskTxtBx42.Visible = true; MskTxtBx43.Visible = true;
            MskTxtBx44.Visible = true; MskTxtBx45.Visible = true; MskTxtBx46.Visible = true; MskTxtBx47.Visible = true;
            MskTxtBx48.Visible = true;
            //SEXTA
            await Task.Delay(20);
            MskTxtBx50.Visible = true; MskTxtBx51.Visible = true; MskTxtBx52.Visible = true; MskTxtBx53.Visible = true;
            MskTxtBx54.Visible = true; MskTxtBx55.Visible = true; MskTxtBx56.Visible = true; MskTxtBx57.Visible = true;
            MskTxtBx58.Visible = true;
            //SETIMA
            await Task.Delay(20);
            MskTxtBx60.Visible = true; MskTxtBx61.Visible = true; MskTxtBx62.Visible = true; MskTxtBx63.Visible = true;
            MskTxtBx64.Visible = true; MskTxtBx65.Visible = true; MskTxtBx66.Visible = true; MskTxtBx67.Visible = true;
            MskTxtBx68.Visible = true;
            //OITAVA
            await Task.Delay(20);
            MskTxtBx70.Visible = true; MskTxtBx71.Visible = true; MskTxtBx72.Visible = true; MskTxtBx73.Visible = true;
            MskTxtBx74.Visible = true; MskTxtBx75.Visible = true; MskTxtBx76.Visible = true; MskTxtBx77.Visible = true;
            MskTxtBx78.Visible = true;
            //NONA
            await Task.Delay(20);
            MskTxtBx80.Visible = true; MskTxtBx81.Visible = true; MskTxtBx82.Visible = true; MskTxtBx83.Visible = true;
            MskTxtBx84.Visible = true; MskTxtBx85.Visible = true; MskTxtBx86.Visible = true; MskTxtBx87.Visible = true;
            MskTxtBx88.Visible = true;
        }

    }
}
