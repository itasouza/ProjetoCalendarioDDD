using DevIO.Business.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DevIO.Business.Interfaces
{
    public interface IEventoRepository : IRepositoryGenerico<Evento>
    {
        Task<IEnumerable<Evento>> ObterTodosEvento();
        Task<Evento> ObterEvento(int id);
    }
}
