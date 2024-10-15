using System;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Jogo_De_Adivinhacao
{
    public partial class Form1 : Form
    {
        //Criado a variável p/armazenar o número sorteado
        private int numeroSorteado;
        //Criado a classe Random p/gerar números aleatórios
        private Random random;
        public Form1()
        {
            InitializeComponent(); //inicializa os componentes do Formulário
            random = new Random(); //Cria uma nova instância de Random
            ReiniciarJogo(); //Chama o método p/iniciar o jogo
        }
        private void btn_Adivinhe_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txt_1.Text, out int palpite))
            {
                // verifica se o palpite é menor  que o número sorteado
                if (palpite < numeroSorteado)
                {
                    lbl_Resultado.Text = "O número é maior."; // informa que o número sorteado é maior 

                }
                else if (palpite > numeroSorteado)
                {
                    lbl_Resultado.Text = "O número é menor."; // informa que o número sorteado é menor
                }
                // O palpite está correto
                else
                {
                    lbl_Resultado.Text = " Parabéns! Você acertou!."; //Mensagem de sucesso
                    btn_Adivinhe.Enabled = false; //Desabilita o botão
                }

            }
            else
            {
                MessageBox.Show("Por favor, insira um número válido.");

            }

        }

        private void btn_Reiniciar_Click(object sender, EventArgs e)
        {
            //Chama o método p/reiniciar o jogo
            ReiniciarJogo();
        }
        private void ReiniciarJogo()
        {
            numeroSorteado = random.Next(1, 100);
            lbl_Resultado.Text = "Tente adivinhar o número!"; //Mensagem p/o Jogador
            txt_1.Clear();//Limpa p/novo palpite
            btn_Adivinhe.Enabled = true;//Habilita o botão de Adivinhe
        }

        private void txt_1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}