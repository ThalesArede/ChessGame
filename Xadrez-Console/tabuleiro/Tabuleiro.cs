namespace tabuleiro
{
    class Tabuleiro
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

        public Peca peca(Posicao pos) // Sobrecarga do método Peca
        {
            return pecas[pos.linha, pos.coluna];
        }

        public bool existePeca(Posicao pos)
        {
            validarPosicao(pos);
            return peca(pos) != null;
        }

        public void colocarPeca(Peca p, Posicao pos) // Operação para colocar peças no tabuleiro
        {
            if (existePeca(pos)) // Vai apresentar a mensagem de erro caso tente colocar uma peça onde já tem outra
            {
                throw new TabuleiroException("Já existe uma peça nesta posição!");
            }
            pecas[pos.linha, pos.coluna] = p; // Acessa a matriz na linha pos.linha, pos.coluna
            p.posicao = pos;
        }

        public bool posicaoValida(Posicao pos) // Método para testar se a posição é valida ou não
        {
            if (pos.linha < 0 || pos.linha >= linhas || pos.coluna < 0 || pos.coluna >= colunas)
            {
                return false;
            }
            return true;
        }
        public void validarPosicao(Posicao pos) // Método recebe posição, caso a posição não seja valida, lança uma exceção
        {
            if (!posicaoValida(pos)) // Se a posição pos não for válida, lançamos uma exceção
            {
                throw new TabuleiroException("Posição Inválida!");
            }
        }
    }
}