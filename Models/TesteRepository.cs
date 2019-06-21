using System.Linq;

namespace ProjLinux.Models
{
    public class TesteRepository: IRepository
    {
        private static Produto[] Dados = new Produto[]
        {
            new Produto{ProdutoId=10,Nome="Caneta",Categoria="Escolar",Preco=100},
            new Produto{ProdutoId=20,Nome="Borracha",Categoria="Escolar",Preco=200},
            new Produto{ProdutoId=30,Nome="Caderno",Categoria="Escolar",Preco=300},
            new Produto{ProdutoId=40,Nome="Lapis",Categoria="Escolar",Preco=50},
            new Produto{ProdutoId=50,Nome="Iphone",Categoria="Eletronicos",Preco=500},
        };
        
        public IQueryable<Produto> Produtos =>Dados.AsQueryable();
    }
}