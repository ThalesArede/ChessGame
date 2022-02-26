namespace tabuleiro
{
    internal class Tabuleiro
    {
        public int linhas { get; set; }  // Numero de linhas
        public int colunas { get; set; }    // Numero de colunas

        private Peca[,] pecas;   // Uma matriz de peças

        public Tabuleiro(int linhas, int colunas) // Construtor para instanciar o número de linhas e colunas que o tabuleiro vai ter
        {
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Peca[linhas, colunas]; 
        }
    }
}