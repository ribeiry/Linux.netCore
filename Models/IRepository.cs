using System.Linq;

namespace ProjLinux.Models
{
    public interface IRepository
    {
     IQueryable<Produto> Produtos{get;}   
    }
}