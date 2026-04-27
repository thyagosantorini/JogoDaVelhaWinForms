using System.Diagnostics;

namespace JogoDaVelhaWinForms
{
    public partial class Form1 : Form
    {
        // Variáveis de estado para controle do fluxo da partida
        bool vezDoX; // Define quem começa. true = X, false = O
        int jogadas; // Contador para identificar empate (máximo 9)
        bool jogoEncerrado; // Trava para impedir cliques após fim da partida

        public Form1()
        {
            InitializeComponent();
        }

        // Método único associado ao evento Click de todos os 9 botões do tabuleiro
        private void btnsClick(object sender, EventArgs e)
        {
            // Ignora cliques se o jogo já acabou ou se o botão já foi usado
            if (jogoEncerrado)
            {
                return;
            }

            Button btn = (Button)sender;

            if (btn.Text != "")
            {
                return;
            }

            // Define o símbolo baseado no turno e incrementa contador
            btn.Text = vezDoX ? "X" : "O";
            jogadas++;

            // Verifica se a jogada atual resultou em vitória ou empate
            if (VerificarVencedor())
            {
                lblStatus.Text = $"Jogador {(vezDoX ? "X" : "O")} Venceu!";
                jogoEncerrado = true;
            }
            else if (jogadas == 9)
            {
                lblStatus.Text = "Empate";
                jogoEncerrado = true;
            }
            else
            {
                // Alterna o turno e atualiza a interface
                vezDoX = !vezDoX;
                lblStatus.Text = $"Vez do jogador {(vezDoX ? "X" : "O")}";
            }
        }

        // Lógica de validação posicional através de uma matriz de strings
        private bool VerificarVencedor()
        {
            // Mapeia o texto dos botões para facilitar a iteração por coordenadas
            string[,] matriz = new string[3, 3]
            {
                {btn1.Text, btn2.Text, btn3.Text },
                {btn4.Text, btn5.Text, btn6.Text },
                {btn7.Text, btn8.Text, btn9.Text }
            };

            // Validação de linhas e colunas usando um único loop
            for (int i = 0; i < 3; i++)
            {
                // Verifica linhas [i,0] [i,1] [i,2]
                if (matriz[i, 0] != "" && matriz[i, 0] == matriz[i, 1] && matriz[i, 1] == matriz[i, 2]) return true;
                // Verifica colunas [0,i] [1,i] [2,i]
                if (matriz[0, i] != "" && matriz[0, i] == matriz[1, i] && matriz[1, i] == matriz[2, i]) return true;

            }

            // Validação das duas diagonais possíveis
            if (matriz[0, 0] != "" && matriz[0, 0] == matriz[1, 1] && matriz[1, 1] == matriz[2, 2]) return true;
            if (matriz[0, 2] != "" && matriz[0, 2] == matriz[1, 1] && matriz[1, 1] == matriz[2, 0]) return true;

            return false;
        }

        // Restaura o estado inicial do jogo e limpa a interface
        private void btnResetar_Click(object sender, EventArgs e)
        {
            // Percorre todos os controles e limpa apenas os botões do tabuleiro
            foreach (var c in Controls)
            {
                if (c is Button btn && btn.Name != "btnResetar")
                    btn.Text = "";
            }

            vezDoX = true;
            jogadas = 0;
            jogoEncerrado = false;
            lblStatus.Text = "Vez do jogador X";
        }
    }
}
