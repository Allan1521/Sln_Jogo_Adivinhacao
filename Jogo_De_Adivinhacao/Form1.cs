using System;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Jogo_De_Adivinhacao
{
    public partial class Form1 : Form
    {
        //Criado a vari�vel p/armazenar o n�mero sorteado
        private int numeroSorteado;
        //Criado a classe Random p/gerar n�meros aleat�rios
        private Random random;
        public Form1()
        {
            InitializeComponent(); //inicializa os componentes do Formul�rio
            random = new Random(); //Cria uma nova inst�ncia de Random
            ReiniciarJogo(); //Chama o m�todo p/iniciar o jogo
        }
        private void btn_Adivinhe_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txt_1.Text, out int palpite))
            {
                // verifica se o palpite � menor  que o n�mero sorteado
                if (palpite < numeroSorteado)
                {
                    lbl_Resultado.Text = "O n�mero � maior."; // informa que o n�mero sorteado � maior 

                }
                else if (palpite > numeroSorteado)
                {
                    lbl_Resultado.Text = "O n�mero � menor."; // informa que o n�mero sorteado � menor
                }
                // O palpite est� correto
                else
                {
                    lbl_Resultado.Text = " Parab�ns! Voc� acertou!."; //Mensagem de sucesso
                    btn_Adivinhe.Enabled = false; //Desabilita o bot�o
                }

            }
            else
            {
                MessageBox.Show("Por favor, insira um n�mero v�lido.");

            }

        }

        private void btn_Reiniciar_Click(object sender, EventArgs e)
        {
            //Chama o m�todo p/reiniciar o jogo
            ReiniciarJogo();
        }
        private void ReiniciarJogo()
        {
            numeroSorteado = random.Next(1, 100);
            lbl_Resultado.Text = "Tente adivinhar o n�mero!"; //Mensagem p/o Jogador
            txt_1.Clear();//Limpa p/novo palpite
            btn_Adivinhe.Enabled = true;//Habilita o bot�o de Adivinhe
        }

        private void txt_1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}