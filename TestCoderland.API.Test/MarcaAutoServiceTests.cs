using Moq;
using TestCoderland.Core.Abstractions.Repositories;
using TestCoderland.Core.Abstractions.Services;
using TestCoderland.Core.Entities;
using TestCoderland.Core.Services;

namespace TestCoderland.Core.Tests
{
    public class MarcaAutoServiceTests
    {
        private readonly Mock<IMarcaAutoRepository> _mockRepository;
        private readonly IMarcaAutoService _service;

        public MarcaAutoServiceTests()
        {
            // Configuramos el Mock del repositorio
            _mockRepository = new Mock<IMarcaAutoRepository>();

            // Creamos el servicio usando el mock del repositorio
            _service = new MarcaAutoService(_mockRepository.Object);
        }

        [Fact]
        public async Task Listar_ReturnsListOfMarcas()
        {
            // Arrange
            var mockData = new List<MarcaAuto>
            {
                new MarcaAuto { Id = 1, Nombre = "Toyota", PaisOrigen = "Japón" },
                new MarcaAuto { Id = 2, Nombre = "Ford", PaisOrigen = "Estados Unidos" }
            };

            _mockRepository.Setup(r => r.Listar()).ReturnsAsync(mockData);

            // Act
            var result = await _service.Listar();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(2, result.Count);
            Assert.Equal("Toyota", result[0].Nombre);
        }

        [Fact]
        public async Task Listar_ReturnsEmptyListWhenNoData()
        {
            // Arrange
            _mockRepository.Setup(r => r.Listar()).ReturnsAsync(new List<MarcaAuto>());

            // Act
            var result = await _service.Listar();

            // Assert
            Assert.NotNull(result);
            Assert.Empty(result);
        }
    }
}
