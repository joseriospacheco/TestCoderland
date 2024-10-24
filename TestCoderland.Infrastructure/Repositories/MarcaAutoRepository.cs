using Microsoft.EntityFrameworkCore;
using TestCoderland.Core.Abstractions.Repositories;
using TestCoderland.Core.Entities;
using TestCoderland.Infrastructure.Data;

namespace TestCoderland.Infrastructure.Repositories
{
    public class MarcaAutoRepository : IMarcaAutoRepository
    {

        private readonly CoderlandDbContext _context;

        public MarcaAutoRepository(CoderlandDbContext context)
        {
            _context = context;
            
        }

        public async Task<List<MarcaAuto>> Listar()
        {
            return await _context.MarcasAuto.ToListAsync();
        }
    }
}
