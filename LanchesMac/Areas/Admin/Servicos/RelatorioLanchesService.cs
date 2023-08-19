using LanchesMac.Context;
using LanchesMac.Models;
using Microsoft.EntityFrameworkCore;

namespace LanchesMac.Areas.Admin.Servicos
{
    public class RelatorioLanchesService
    {
        private readonly AppDbContext _context;

        public RelatorioLanchesService(AppDbContext context)        
        {
            _context = context;
        }

        public async Task<IEnumerable<Lanche>> GetLanchesReport()
        {
            var lanches = await _context.Lanches.ToListAsync();

            if (!lanches.Any())
            {
                return default;
            }
            return lanches;
        }
        public async Task<IEnumerable<Categoria>> GetCategoriasReport()
        {
            var categorias = await _context.Categorias.ToListAsync();

            if (!categorias.Any())
            {
                return default;
            }
            return categorias;
        }
    }
}
