// classe posicao
namespace tabuleiro
{
    internal class Posicao
    {
        public int linha { get; set; } // Encapsulamento, atributos podem ser acessado e alterados por outras classes
        public int coluna { get; set; }

        public Posicao(int linha, int coluna) // Construtor, atribui os valores diretamente para objetos instanciados
        {
            this.linha = linha; // A palavra-chave this é usada para acessar um membro da instância da própria classe
            this.coluna = coluna;
        }

        public override string ToString() // Método ToString para converter o objeto para string
        {
            return linha
                + ", "
                + coluna;
        }
    }
}
