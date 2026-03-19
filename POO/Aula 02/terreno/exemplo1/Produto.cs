namespace exemplo1
{
    internal class Produto
    {
        //Campos da classe
        public string nome;
        public double preco;
        public int quantidade;

        //Construtor
        public Produto(string nome, double preco)
        {
            this.nome = nome;
            this.preco = preco;
            quantidade = 0;
        }
        public Produto(string nome, double preco, int quantidade)
        {
            this.nome = nome;
            this.preco = preco;
            this.quantidade = quantidade;
        }

        //Métodos da classe
        public double Valor_Total_Em_Estoque()
        {
            return preco * quantidade;
        }

        public void Adicionar_Produtos(int qtd)
        {
            quantidade += qtd;
        }

        public void Remover_Produtos(int qtd)
        {
            quantidade -= qtd;            
        }

        public string Dados_do_Produto()
        {
            return ($"Nome: {nome}, Preço: {preco}, Quantidade: {quantidade}, " +
                $"Total: {Valor_Total_Em_Estoque()}");
        }
    }
}
