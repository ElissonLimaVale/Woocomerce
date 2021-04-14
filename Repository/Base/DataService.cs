

using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using WooComerce.Models;

namespace WooComerce.Repository
{
    public class DataService : IDataService
    {
        private readonly ApplicationContext _context;

        public DataService(ApplicationContext context)
        {
            _context = context;
        }

        public void Inicializate()
        {
            _context.Database.EnsureCreated();

            //List<ProdutoViewModel> livros = JsonConvert.DeserializeObject<List<ProdutoViewModel>>(File.ReadAllText("livros.json"));

            //foreach (ProdutoViewModel livro in livros)
            //{
            //    _context.Produto.Add(livro);
            //}

            //_context.SaveChanges();
        }
    }
}
