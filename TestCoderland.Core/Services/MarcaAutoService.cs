using TestCoderland.Core.Abstractions.Repositories;
using TestCoderland.Core.Abstractions.Services;
using TestCoderland.Core.Entities;

namespace TestCoderland.Core.Services
{
    public class MarcaAutoService : IMarcaAutoService
    {
        private readonly IMarcaAutoRepository _repository;

        public MarcaAutoService(IMarcaAutoRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<MarcaAuto>> Listar()
        {
            return  await  _repository.Listar();
        }
    }
}
