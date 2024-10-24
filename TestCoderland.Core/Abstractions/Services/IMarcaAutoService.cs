using TestCoderland.Core.Entities;

namespace TestCoderland.Core.Abstractions.Services
{
    public interface IMarcaAutoService
    {
        Task<List<MarcaAuto>> Listar();
    }
}
