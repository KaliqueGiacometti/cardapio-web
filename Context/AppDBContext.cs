using Microsoft.EntityFrameworkCore;

namespace CardapioWeb.Context
{
    public class AppDBContext: DbContext
    {
        public AppDBContext(DbContextOption<AppDBContext> options): base(options) { }

    }
}
