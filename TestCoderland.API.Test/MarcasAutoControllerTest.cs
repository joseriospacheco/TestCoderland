using Moq;
using TestCoderland.API.Controllers;
using TestCoderland.Core.Abstractions.Services;
using TestCoderland.Core.Entities;

namespace TestCoderland.API.Test
{
    public class MarcasAutoControllerTest
    {

        public class MarcasAutoControllerTests
        {
            private readonly Mock<IMarcaAutoService> _mockService;
            private readonly MarcasAutoController _controller;

            public MarcasAutoControllerTests()
            {
                _mockService = new Mock<IMarcaAutoService>();
                _controller = new MarcasAutoController(_mockService.Object);
            }

            [Fact]
            public async Task Get_ReturnsListOfMarcas()
            {
                // Arrange
                var mockData = new List<MarcaAuto>
            {
                new MarcaAuto { Id = 1, Nombre = "Toyota", PaisOrigen = "Japón" },
                new MarcaAuto { Id = 2, Nombre = "Ford", PaisOrigen = "Estados Unidos" }
            };

                _mockService.Setup(s => s.Listar()).ReturnsAsync(mockData);

                // Act
                var result = await _controller.Get();

                // Assert
                Assert.NotNull(result);
                Assert.Equal(2, result.Count);
                Assert.Equal("Toyota", result[0].Nombre);
            }

            [Fact]
            public async Task Get_ReturnsEmptyListWhenNoData()
            {
                // Arrange
                _mockService.Setup(s => s.Listar()).ReturnsAsync(new List<MarcaAuto>());

                // Act
                var result = await _controller.Get();

                // Assert
                Assert.NotNull(result);
                Assert.Empty(result);
            }
        }

    }
}