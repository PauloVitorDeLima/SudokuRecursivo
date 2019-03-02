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
       //Action apos clicar o botao de Inicio
        private void button1_Click(object sender, EventArgs e)
        {
            //Adiciona a quantidade de campos vazios para a variavel "Vazios" do tipo Inteiro
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
            //Cria valor aleatório
            Random valorRandom = new Random();
            //Cria duas variaveis Inteiras
            int Linha;
            int Coluna;
            //Repete ate que todos os valores escolhidos para serem repetidos sejam atendidos
            for (int i = 1; i < Vazios; i++)
            {
                //escolhe para a Linha um valor aleatorio entre 0 e 8
                Linha = valorRandom.Next(0, 8);
                //escolhe para a Coluna um valor aleatorio entre 0 e 8
                Coluna = valorRandom.Next(0, 8);
                //no local aleatorio adiciona o valor 0
                field[Linha,Coluna] = 0;
            }
            //Chama o Metodo que mostra os espacos da MaskTextBox
            MostraEspacosAsync();
            //Chama o Metodo que adiciona os valores para os espacos
            AdicionaValoresAsync(field);
            
        }
         
            //System.Threading.Thread.Sleep(1000);
        
        public async void AdicionaValoresAsync(int[,]field)
        {
            //PRIMEIRA LINHA
           //Atraso de 0,1 segundo para aparecer aos poucos
            await Task.Delay(100);
            //verifica se o campo esta igual a 0
            if (field[0, 0] == 0)
            //se estiver adiciona para o local o valor null;
                MskTxtBx00.Text = null;
            else
            //se nao adiciona o valor determinado da matriz
                MskTxtBx00.Text = field[0, 0].ToString();

            await Task.Delay(100);
            if (field[0, 1] == 0)
                MskTxtBx01.Text = null;
            
            else
                MskTxtBx01.Text = field[0, 1].ToString();

            await Task.Delay(100);
            if (field[0, 2] == 0)
                MskTxtBx02.Text = null;
            else
                MskTxtBx02.Text = field[0, 2].ToString();

            await Task.Delay(100);   
            if (field[0, 3] == 0)
                MskTxtBx03.Text = null;
            else
                MskTxtBx03.Text = field[0, 3].ToString();

            await Task.Delay(100);
            if (field[0, 4] == 0)
                MskTxtBx04.Text = null;
            else
                MskTxtBx04.Text = field[0, 4].ToString();

            await Task.Delay(100);
            if (field[0, 5] == 0)
                MskTxtBx05.Text = null;
            else
                MskTxtBx05.Text = field[0, 5].ToString();

            await Task.Delay(100);
            if (field[0, 6] == 0)
                MskTxtBx06.Text = null;
            else
                MskTxtBx06.Text = field[0, 6].ToString();

            await Task.Delay(100);
            if (field[0, 7] == 0)
                MskTxtBx07.Text = null;
            else
                MskTxtBx07.Text = field[0, 7].ToString();
            await Task.Delay(100);

            if (field[0, 8] == 0)
                MskTxtBx07.Text = null;
            else
                MskTxtBx08.Text = field[0, 8].ToString();

            //SEGUNDA LINHA

            await Task.Delay(100);
            if (field[1, 0] == 0)
                MskTxtBx10.Text = null;
            else
                MskTxtBx10.Text = field[1, 0].ToString();
            await Task.Delay(100);
            if (field[1, 1] == 0)
                MskTxtBx11.Text = null;
            else
                MskTxtBx11.Text = field[1, 1].ToString();
            await Task.Delay(100);
            if (field[1, 2] == 0)
                MskTxtBx12.Text = null;
            else
                MskTxtBx12.Text = field[1, 2].ToString();
            await Task.Delay(100);
            if (field[1, 3] == 0)
                MskTxtBx13.Text = null;
            else
                MskTxtBx13.Text = field[1, 3].ToString();
            await Task.Delay(100);
            if (field[1, 4] == 0)
                MskTxtBx14.Text = null;
            else
                MskTxtBx14.Text = field[1, 4].ToString();
            await Task.Delay(100);
            if (field[1, 5] == 0)
                MskTxtBx15.Text = null;
            else
                MskTxtBx15.Text = field[1, 5].ToString();
            await Task.Delay(100);
            if (field[1, 6] == 0)
                MskTxtBx16.Text = null;
            else
                MskTxtBx16.Text = field[1, 6].ToString();
            await Task.Delay(100);
            if (field[1, 7] == 0)
                MskTxtBx17.Text = null;
            else
                MskTxtBx17.Text = field[1, 7].ToString();
            await Task.Delay(100);
            if (field[1, 8] == 0)
                MskTxtBx18.Text = null;
            else
                MskTxtBx18.Text = field[1, 8].ToString();


            //TERCEIRA LINHA
            await Task.Delay(100);
            if (field[2, 0] == 0)
                MskTxtBx20.Text = null;
            else
                MskTxtBx20.Text = field[2, 0].ToString();
            await Task.Delay(100);
            if (field[2, 1] == 0)
                MskTxtBx21.Text = null;
            else
                MskTxtBx21.Text = field[2, 1].ToString();
            await Task.Delay(100);
            if (field[2, 2] == 0)
                MskTxtBx22.Text = null;
            else
                MskTxtBx22.Text = field[2, 2].ToString();
            await Task.Delay(100);
            if (field[2, 3] == 0)
                MskTxtBx23.Text = null;
            else
                MskTxtBx23.Text = field[2, 3].ToString();
            await Task.Delay(100);
            if (field[2, 4] == 0)
                MskTxtBx24.Text = null;
            else
                MskTxtBx24.Text = field[2, 4].ToString();
            await Task.Delay(100);
            if (field[2, 5] == 0)
                MskTxtBx25.Text = null;
            else
                MskTxtBx25.Text = field[2, 5].ToString();
            await Task.Delay(100);
            if (field[2, 6] == 0)
                MskTxtBx26.Text = null;
            else
                MskTxtBx26.Text = field[2, 6].ToString();
            await Task.Delay(100);
            if (field[2, 7] == 0)
                MskTxtBx27.Text = null;
            else
                MskTxtBx27.Text = field[2, 7].ToString();
            await Task.Delay(100);
            if (field[2, 8] == 0)
                MskTxtBx28.Text = null;
            else
                MskTxtBx28.Text = field[2, 8].ToString();


            //QUARTA LINHA

            await Task.Delay(100);
            if (field[3, 0] == 0)
                MskTxtBx30.Text = null;
            else
                MskTxtBx30.Text = field[3, 0].ToString();
            await Task.Delay(100);
            if (field[3, 1] == 0)
                MskTxtBx31.Text = null;
            else
                MskTxtBx31.Text = field[3, 1].ToString();
            await Task.Delay(100);
            if (field[3, 2] == 0)
                MskTxtBx32.Text = null;
            else
                MskTxtBx32.Text = field[3, 2].ToString();
            await Task.Delay(100);
            if (field[3, 3] == 0)
                MskTxtBx33.Text = null;
            else
                MskTxtBx33.Text = field[3, 3].ToString();
            await Task.Delay(100);
            if (field[3, 4] == 0)
                MskTxtBx34.Text = null;
            else
                MskTxtBx34.Text = field[3, 4].ToString();
            await Task.Delay(100);
            if (field[3, 5] == 0)
                MskTxtBx35.Text = null;
            else
                MskTxtBx35.Text = field[3, 5].ToString();
            await Task.Delay(100);
            if (field[3, 6] == 0)
                MskTxtBx36.Text = null;
            else
                MskTxtBx36.Text = field[3, 6].ToString();
            await Task.Delay(100);
            if (field[3, 7] == 0)
                MskTxtBx37.Text = null;
            else
                MskTxtBx37.Text = field[3, 7].ToString();

            await Task.Delay(100);
            if (field[3, 8] == 0)
                MskTxtBx38.Text = null;
            else
                MskTxtBx38.Text = field[3, 8].ToString();

            //QUINTA LINHA
            await Task.Delay(100);
                if (field[4, 0] == 0)
                MskTxtBx40.Text = null;
            else
                MskTxtBx40.Text = field[4, 0].ToString();

            await Task.Delay(100);
            if (field[4, 1] == 0)
                MskTxtBx41.Text = null;
            else
                MskTxtBx41.Text = field[4, 1].ToString();
            await Task.Delay(100);
            if (field[4, 2] == 0)
                MskTxtBx42.Text = null;
            else
                MskTxtBx42.Text = field[4, 2].ToString();
            await Task.Delay(100);
            if (field[4, 3] == 0)
                MskTxtBx43.Text = null;
            else
                MskTxtBx43.Text = field[4, 3].ToString();
            await Task.Delay(100);
            if (field[4, 4] == 0)
                MskTxtBx44.Text = null;
            else
                MskTxtBx44.Text = field[4, 4].ToString();
            await Task.Delay(100);
            if (field[4, 5] == 0)
                MskTxtBx45.Text = null;
            else
                MskTxtBx45.Text = field[4, 5].ToString();
            await Task.Delay(100);
            if (field[4, 6] == 0)
                MskTxtBx46.Text = null;
            else
                MskTxtBx46.Text = field[4, 6].ToString();
            await Task.Delay(100);
            if (field[4, 7] == 0)
                MskTxtBx47.Text = null;
            else
                MskTxtBx47.Text = field[4, 7].ToString();
            await Task.Delay(100);
            if (field[4, 8] == 0)
                MskTxtBx48.Text = null;
            else
                MskTxtBx48.Text = field[4, 8].ToString();


            // SEXTA LINHA
            await Task.Delay(100);
            if (field[5, 0] == 0)
                MskTxtBx50.Text = null;
            else
                MskTxtBx50.Text = field[5, 0].ToString();
            await Task.Delay(100);
            if (field[5, 1] == 0)
                MskTxtBx51.Text = null;
            else
                MskTxtBx51.Text = field[5, 1].ToString();
            await Task.Delay(100);
            if (field[5, 2] == 0)
                MskTxtBx52.Text = null;
            else
                MskTxtBx52.Text = field[5, 2].ToString();
            await Task.Delay(100);
            if (field[5, 3] == 0)
                MskTxtBx53.Text = null;
            else
                MskTxtBx53.Text = field[5, 3].ToString();
            await Task.Delay(100);
            if (field[5, 4] == 0)
                MskTxtBx54.Text = null;
            else
                MskTxtBx54.Text = field[5, 4].ToString();
            await Task.Delay(100);
            if (field[5, 5] == 0)
                MskTxtBx55.Text = null;
            else
                MskTxtBx55.Text = field[5, 5].ToString();
            await Task.Delay(100);
            if (field[5, 6] == 0)
                MskTxtBx56.Text = null;
            else
                MskTxtBx56.Text = field[5, 6].ToString();
            await Task.Delay(100);
            if (field[5, 7] == 0)
                MskTxtBx57.Text = null;
            else
                MskTxtBx57.Text = field[5, 7].ToString();
            await Task.Delay(100);
            if (field[5, 8] == 0)
                MskTxtBx58.Text = null;
            else
                MskTxtBx58.Text = field[5, 8].ToString();


            //SETIMA LINHA

            await Task.Delay(100);
            if (field[6, 0] == 0)
                MskTxtBx60.Text = null;
            else
                MskTxtBx60.Text = field[6, 0].ToString();
            await Task.Delay(100);
            if (field[6, 1] == 0)
                MskTxtBx61.Text = null;
            else
                MskTxtBx61.Text = field[6, 1].ToString();
            await Task.Delay(100);
            if (field[6, 2] == 0)
                MskTxtBx62.Text = null;
            else
                MskTxtBx62.Text = field[6, 2].ToString();
            await Task.Delay(100);
            if (field[6, 3] == 0)
                MskTxtBx63.Text = null;
            else
                MskTxtBx63.Text = field[6, 3].ToString();
            await Task.Delay(100);
            if (field[6, 4] == 0)
                MskTxtBx64.Text = null;
            else
                MskTxtBx64.Text = field[6, 4].ToString();
            await Task.Delay(100);
            if (field[6, 5] == 0)
                MskTxtBx65.Text = null;
            else
                MskTxtBx65.Text = field[6, 5].ToString();
            await Task.Delay(100);
            if (field[6, 6] == 0)
                MskTxtBx66.Text = null;
            else
                MskTxtBx66.Text = field[6, 6].ToString();
            await Task.Delay(100);
            if (field[6, 7] == 0)
                MskTxtBx67.Text = null;
            else
                MskTxtBx67.Text = field[6, 7].ToString();
            await Task.Delay(100);
            if (field[6, 8] == 0)
                MskTxtBx68.Text = null;
            else
                MskTxtBx68.Text = field[6, 8].ToString();


            //OITAVA
            await Task.Delay(100);
            if (field[7, 0] == 0)
                MskTxtBx70.Text = null;
            else
                MskTxtBx70.Text = field[7, 0].ToString();
            await Task.Delay(100);
            if (field[7, 1] == 0)
                MskTxtBx71.Text = null;
            else
                MskTxtBx71.Text = field[7, 1].ToString();
            await Task.Delay(100);
            if (field[7, 2] == 0)
                MskTxtBx72.Text = null;
            else
                MskTxtBx72.Text = field[7, 2].ToString();
            await Task.Delay(100);
            if (field[7, 3] == 0)
                MskTxtBx73.Text = null;
            else
                MskTxtBx73.Text = field[7, 3].ToString();
            await Task.Delay(100);
            if (field[7, 4] == 0)
                MskTxtBx74.Text = null;
            else
                MskTxtBx74.Text = field[7, 4].ToString();
            await Task.Delay(100);
            if (field[7, 5] == 0)
                MskTxtBx75.Text = null;
            else
                MskTxtBx75.Text = field[7, 5].ToString();
            await Task.Delay(100);
            if (field[7, 6] == 0)
                MskTxtBx76.Text = null;
            else
                MskTxtBx76.Text = field[7, 6].ToString();
            await Task.Delay(100);
            if (field[7, 7] == 0)
                MskTxtBx77.Text = null;
            else
                MskTxtBx77.Text = field[7, 7].ToString();
            await Task.Delay(100);
            if (field[7, 8] == 0)
                MskTxtBx78.Text = null;
            else
                MskTxtBx68.Text = field[7, 8].ToString();


            // NONA
            await Task.Delay(100);
            if (field[8, 0] == 0)
                MskTxtBx80.Text = null;
            else
                MskTxtBx80.Text = field[8, 0].ToString();
            await Task.Delay(100);
            if (field[8, 1] == 0)
                MskTxtBx81.Text = null;
            else
                MskTxtBx81.Text = field[8, 1].ToString();
            await Task.Delay(100);
            if (field[8, 2] == 0)
                MskTxtBx82.Text = null;
            else
                MskTxtBx82.Text = field[8, 2].ToString();
            await Task.Delay(100);
            if (field[8, 3] == 0)
                MskTxtBx83.Text = null;
            else
                MskTxtBx83.Text = field[8, 3].ToString();
            await Task.Delay(100);
            if (field[8, 4] == 0)
                MskTxtBx84.Text = null;
            else
                MskTxtBx84.Text = field[8, 4].ToString();
            await Task.Delay(100);
            if (field[8, 5] == 0)
                MskTxtBx85.Text = null;
            else
                MskTxtBx85.Text = field[8, 5].ToString();
            await Task.Delay(100);
            if (field[8, 6] == 0)
                MskTxtBx86.Text = null;
            else
                MskTxtBx86.Text = field[8, 6].ToString();
            await Task.Delay(100);
            if (field[8, 7] == 0)
                MskTxtBx87.Text = null;
            else
                MskTxtBx87.Text = field[8, 7].ToString();
            await Task.Delay(100);
            if (field[8, 8] == 0)
                MskTxtBx88.Text = null;
            else
                MskTxtBx88.Text = field[8, 8].ToString();



        }
        public async void MostraEspacosAsync()
        {
            //PRIMEIRA LINHA
            //Mostra os MaskTextBox com atraso de 0,5 segundos para apresentar
            await Task.Delay(500);
            MskTxtBx00.Visible = true; MskTxtBx01.Visible = true; MskTxtBx02.Visible = true; MskTxtBx03.Visible = true;
            MskTxtBx04.Visible = true; MskTxtBx05.Visible = true; MskTxtBx06.Visible = true; MskTxtBx07.Visible = true;
            MskTxtBx08.Visible = true;
            //SEGUNDA
            await Task.Delay(500);
            MskTxtBx10.Visible = true; MskTxtBx11.Visible = true; MskTxtBx12.Visible = true; MskTxtBx13.Visible = true;
            MskTxtBx14.Visible = true; MskTxtBx15.Visible = true; MskTxtBx16.Visible = true; MskTxtBx17.Visible = true;
            MskTxtBx18.Visible = true;
            //TERCEIRA
            await Task.Delay(500);
            MskTxtBx20.Visible = true; MskTxtBx21.Visible = true; MskTxtBx22.Visible = true; MskTxtBx23.Visible = true;
            MskTxtBx24.Visible = true; MskTxtBx25.Visible = true; MskTxtBx26.Visible = true; MskTxtBx27.Visible = true;
            MskTxtBx28.Visible = true;
            //QUARTA
            await Task.Delay(500);
            MskTxtBx30.Visible = true; MskTxtBx31.Visible = true; MskTxtBx32.Visible = true; MskTxtBx33.Visible = true;
            MskTxtBx34.Visible = true; MskTxtBx35.Visible = true; MskTxtBx36.Visible = true; MskTxtBx37.Visible = true;
            MskTxtBx38.Visible = true;
            //Quinta
            await Task.Delay(500);
            MskTxtBx40.Visible = true; MskTxtBx41.Visible = true; MskTxtBx42.Visible = true; MskTxtBx43.Visible = true;
            MskTxtBx44.Visible = true; MskTxtBx45.Visible = true; MskTxtBx46.Visible = true; MskTxtBx47.Visible = true;
            MskTxtBx48.Visible = true;
            //SEXTA
            await Task.Delay(500);
            MskTxtBx50.Visible = true; MskTxtBx51.Visible = true; MskTxtBx52.Visible = true; MskTxtBx53.Visible = true;
            MskTxtBx54.Visible = true; MskTxtBx55.Visible = true; MskTxtBx56.Visible = true; MskTxtBx57.Visible = true;
            MskTxtBx58.Visible = true;
            //SETIMA
            await Task.Delay(500);
            MskTxtBx60.Visible = true; MskTxtBx61.Visible = true; MskTxtBx62.Visible = true; MskTxtBx63.Visible = true;
            MskTxtBx64.Visible = true; MskTxtBx65.Visible = true; MskTxtBx66.Visible = true; MskTxtBx67.Visible = true;
            MskTxtBx68.Visible = true;
            //OITAVA
            await Task.Delay(500);
            MskTxtBx70.Visible = true; MskTxtBx71.Visible = true; MskTxtBx72.Visible = true; MskTxtBx73.Visible = true;
            MskTxtBx74.Visible = true; MskTxtBx75.Visible = true; MskTxtBx76.Visible = true; MskTxtBx77.Visible = true;
            MskTxtBx78.Visible = true;
            //NONA
            MskTxtBx80.Visible = true; MskTxtBx81.Visible = true; MskTxtBx82.Visible = true; MskTxtBx83.Visible = true;
            MskTxtBx84.Visible = true; MskTxtBx85.Visible = true; MskTxtBx86.Visible = true; MskTxtBx87.Visible = true;
            MskTxtBx88.Visible = true;
        }

    }
}
