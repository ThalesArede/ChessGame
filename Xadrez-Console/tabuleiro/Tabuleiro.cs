namespace tabuleiro
{
    internal class Tabuleiro
    {
        public int linhas { get; set; }  // Numero de linhas
        public int colunas { get; set; }    // Numero de colunas

        private Peca[,] pecas;   // Uma matriz de peças

        public Tabuleiro(int linhas, int colunas) // Construtor para instanciar o número de linhas e colunas que o tabuleiro vai ter
        {
            this.linhas = linhas; // A palavra-chave this é usada para acessar um membro da instância da própria classe
            this.colunas = colunas;
            pecas = new Peca[linhas, colunas]; 
        }

        public Peca peca(int linha, int coluna)
        {
            return pecas[linha, coluna];
        }
    }
}