using TestCoderland.Core.Entities;

namespace TestCoderland.Core.Abstractions.Repositories
{
    public interface IMarcaAutoRepository
    {
        Task<List<MarcaAuto>> Listar();
    }
}
