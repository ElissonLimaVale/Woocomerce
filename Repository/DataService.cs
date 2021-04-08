using Ecomerce_Profetional;

namespace WooComerce.Repository
{
    public class DataService
    {
        private readonly ApplicationContext _context;

        public DataService(ApplicationContext context)
        {
            _context = context;
        }

        public void Inicializate()
        {
            _context.Database.EnsureCreated();

        }
    }
}
