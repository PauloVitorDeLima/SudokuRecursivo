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
            //Adiciona a quantidade de campos vazios para a variavel "Vazios" do tipo Inteiro
            int Vazios = Convert.ToInt16(NumericCamposVazios.Value);
            //Numero de Elementos
            int Elemento = 3;
            int[,] Campos = new int[9, 9];  //matriz onde será armazenado o sudoku
            Random numeroAleatorio = new Random();
            int Aleatorio = numeroAleatorio.Next(0,10); //valor aleatorio para não gerar o mesmo sudoku
            //repetição para cada bloco
            for (int bloco = 0; bloco < Elemento; bloco++, Aleatorio++)
            {
                //repetição para cada linha
                for (int linha = 0; linha < Elemento; linha++, Aleatorio += Elemento)
                {
                    int Coluna = 0;
                    //Chama método recursivo para adicionar valores
                    ColunaRecursiva(Campos, Elemento, bloco, linha, Coluna, Aleatorio);
                }
            }
            //Cria valor aleatório
            Random valorRandom = new Random();
            //Cria duas variaveis Inteiras para Linha e Coluna
            int LinhaRandom;
            int ColunaRandom;
            //
            for (int i = 0; i < Vazios; i++)
            {
                //escolhe para a Linha um valor aleatorio entre 0 e 8
                LinhaRandom = valorRandom.Next(0, 9);
                //escolhe para a Coluna um valor aleatorio entre 0 e 8
                ColunaRandom = valorRandom.Next(0, 9);
                //no local aleatorio adiciona o valor 0
                Campos[LinhaRandom,ColunaRandom] = 0;
            }
            //Chama o Metodo que mostra os espacos da MaskTextBox
            //MostraEspacosAsync();
            //Chama o Metodo que adiciona os valores para os espacos
            AdicionaValoresAsync(Campos);
            
        }
        //RECURSIVIDADE PARA ADICIONAR VALORES NA MATRIZ
        private static int ColunaRecursiva(int[,] Campos, int Elemento, int Bloco, int Linha, int Coluna, int Aleatorio)
        {
            if (Coluna >= 9)
            {
                //Repetição para englobar a matriz inteira
                for (int i = 0; i < Elemento * Elemento; i++)
                {
                    for (int j = 0; i < Elemento * Elemento; i++)
                    {
                        //Adiciona todos os valores a Matriz
                        return Campos[i, j];
                    }
                }
            }
            else
            {
                //Adiciona ao campo o resto entre aleatório e 9 somando + 1
                Campos[Elemento * Bloco + Linha, Coluna] = (Aleatorio % (Elemento * Elemento) + 1);
                return ColunaRecursiva(Campos, Elemento, Bloco, Linha, Coluna = Coluna + 1, Aleatorio = Aleatorio + 1);
            }
            //Retorna caso não seja satisfeita a condição;
            return 0;
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
            await Task.Delay(400);
            AdicionaValores(MskTxtBx00, field[0,0]); await Task.Delay(50); AdicionaValores(MskTxtBx01, field[0, 1]); await Task.Delay(50); AdicionaValores(MskTxtBx02, field[0, 2]); await Task.Delay(50); AdicionaValores(MskTxtBx03, field[0, 3]); await Task.Delay(50);
            AdicionaValores(MskTxtBx04, field[0, 4]); await Task.Delay(50); AdicionaValores(MskTxtBx05, field[0, 5]); await Task.Delay(50); AdicionaValores(MskTxtBx06, field[0, 6]); await Task.Delay(50); AdicionaValores(MskTxtBx07, field[0, 7]); await Task.Delay(50);
            AdicionaValores(MskTxtBx08, field[0, 8]);
            //SEGUNDA LINHA
            await Task.Delay(400);
            AdicionaValores(MskTxtBx10, field[1, 0]); await Task.Delay(50); AdicionaValores(MskTxtBx11, field[1, 1]); await Task.Delay(50); AdicionaValores(MskTxtBx12, field[1, 2]); await Task.Delay(50); AdicionaValores(MskTxtBx13, field[1, 3]); await Task.Delay(50);
            AdicionaValores(MskTxtBx14, field[1, 4]); await Task.Delay(50); AdicionaValores(MskTxtBx15, field[1, 5]); await Task.Delay(50); AdicionaValores(MskTxtBx16, field[1, 6]); await Task.Delay(50); AdicionaValores(MskTxtBx17, field[1, 7]); await Task.Delay(50);
            AdicionaValores(MskTxtBx18, field[1, 8]);
            //TERCEIRA LINHA
            await Task.Delay(400);
            AdicionaValores(MskTxtBx20, field[2, 0]); await Task.Delay(50); AdicionaValores(MskTxtBx21, field[2, 1]); await Task.Delay(50); AdicionaValores(MskTxtBx22, field[2, 2]); await Task.Delay(50); AdicionaValores(MskTxtBx23, field[2, 3]); await Task.Delay(50);
            AdicionaValores(MskTxtBx24, field[2, 4]); await Task.Delay(50); AdicionaValores(MskTxtBx25, field[2, 5]); await Task.Delay(50); AdicionaValores(MskTxtBx26, field[2, 6]); await Task.Delay(50); AdicionaValores(MskTxtBx27, field[2, 7]); await Task.Delay(50);
            AdicionaValores(MskTxtBx28, field[2, 8]);
            //QUARTA LINHA
            await Task.Delay(400);
            AdicionaValores(MskTxtBx30, field[3, 0]); await Task.Delay(50); AdicionaValores(MskTxtBx31, field[3, 1]); await Task.Delay(50); AdicionaValores(MskTxtBx32, field[3, 2]); await Task.Delay(50); AdicionaValores(MskTxtBx33, field[3, 3]); await Task.Delay(50);
            AdicionaValores(MskTxtBx34, field[3, 4]); await Task.Delay(50); AdicionaValores(MskTxtBx35, field[3, 5]); await Task.Delay(50); AdicionaValores(MskTxtBx36, field[3, 6]); await Task.Delay(50); AdicionaValores(MskTxtBx37, field[3, 7]); await Task.Delay(50);
            AdicionaValores(MskTxtBx38, field[3, 8]);
            //QUINTA LINHA
            await Task.Delay(400);
            AdicionaValores(MskTxtBx40, field[4, 0]); await Task.Delay(50); AdicionaValores(MskTxtBx41, field[4, 1]); await Task.Delay(50); AdicionaValores(MskTxtBx42, field[4, 2]); await Task.Delay(50); AdicionaValores(MskTxtBx43, field[4, 3]); await Task.Delay(50);
            AdicionaValores(MskTxtBx44, field[4, 4]); await Task.Delay(50); AdicionaValores(MskTxtBx45, field[4, 5]); await Task.Delay(50); AdicionaValores(MskTxtBx46, field[4, 6]); await Task.Delay(50); AdicionaValores(MskTxtBx47, field[4, 7]); await Task.Delay(50);
            AdicionaValores(MskTxtBx48, field[4, 8]);
            //SEXTA LINHA
            await Task.Delay(400);
            AdicionaValores(MskTxtBx50, field[5, 0]); await Task.Delay(50); AdicionaValores(MskTxtBx51, field[5, 1]); await Task.Delay(50); AdicionaValores(MskTxtBx52, field[5, 2]); await Task.Delay(50); AdicionaValores(MskTxtBx53, field[5, 3]); await Task.Delay(50);
            AdicionaValores(MskTxtBx54, field[5, 4]); await Task.Delay(50); AdicionaValores(MskTxtBx55, field[5, 5]); await Task.Delay(50); AdicionaValores(MskTxtBx56, field[5, 6]); await Task.Delay(50); AdicionaValores(MskTxtBx57, field[5, 7]); await Task.Delay(50);
            AdicionaValores(MskTxtBx58, field[5, 8]);
            //SETIMA LINHA
            await Task.Delay(400);
            AdicionaValores(MskTxtBx60, field[6, 0]); await Task.Delay(50); AdicionaValores(MskTxtBx61, field[6, 1]); await Task.Delay(50); AdicionaValores(MskTxtBx62, field[6, 2]); await Task.Delay(50); AdicionaValores(MskTxtBx63, field[6, 3]); await Task.Delay(50);
            AdicionaValores(MskTxtBx64, field[6, 4]); await Task.Delay(50); AdicionaValores(MskTxtBx65, field[6, 5]); await Task.Delay(50); AdicionaValores(MskTxtBx66, field[6, 6]); await Task.Delay(50); AdicionaValores(MskTxtBx67, field[6, 7]); await Task.Delay(50);
            AdicionaValores(MskTxtBx68, field[6, 8]);
            //OITAVA LINHA
            await Task.Delay(400);
            AdicionaValores(MskTxtBx70, field[7, 0]); await Task.Delay(50); AdicionaValores(MskTxtBx71, field[7, 1]); await Task.Delay(50); AdicionaValores(MskTxtBx72, field[7, 2]); await Task.Delay(50); AdicionaValores(MskTxtBx73, field[7, 3]); await Task.Delay(50);
            AdicionaValores(MskTxtBx74, field[7, 4]); await Task.Delay(50); AdicionaValores(MskTxtBx75, field[7, 5]); await Task.Delay(50); AdicionaValores(MskTxtBx76, field[7, 6]); await Task.Delay(50); AdicionaValores(MskTxtBx77, field[7, 7]); await Task.Delay(50);
            AdicionaValores(MskTxtBx78, field[7, 8]);
            //NONA LINHA
            await Task.Delay(400);
            AdicionaValores(MskTxtBx80, field[8, 0]); await Task.Delay(50); AdicionaValores(MskTxtBx81, field[8, 1]); await Task.Delay(50); AdicionaValores(MskTxtBx82, field[8, 2]); await Task.Delay(50); AdicionaValores(MskTxtBx83, field[8, 3]); await Task.Delay(50);
            AdicionaValores(MskTxtBx84, field[8, 4]); await Task.Delay(50); AdicionaValores(MskTxtBx85, field[8, 5]); await Task.Delay(50); AdicionaValores(MskTxtBx86, field[8, 6]); await Task.Delay(50); AdicionaValores(MskTxtBx87, field[8, 7]); await Task.Delay(50);
            AdicionaValores(MskTxtBx88, field[8, 8]);
        }
    }
}
