using DevIO.Business.Interfaces;
using DevIO.Business.Models;
using DevIO.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevIO.Data.Repository
{

    public class EventoRepository : RepositoryGenerico<Evento>, IEventoRepository
    {
        public EventoRepository(MeuDbContext context) : base(context) { }

        public async Task<Evento> ObterEvento(int id)
        {
            return await Db.Eventos.AsNoTracking().FirstOrDefaultAsync(p => p.EventoID == id);
        }

        public async Task<IEnumerable<Evento>> ObterTodosEvento()
        {
            return await Db.Eventos.AsNoTracking().OrderBy(p => p.title).ToListAsync();
        }
    }
}
