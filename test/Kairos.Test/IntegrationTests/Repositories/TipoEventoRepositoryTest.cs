namespace Kairos.Test.IntegrationTests.Repositories;
public class TipoEventoRepositoryTest
{
    #region </Configuration>
        private async Task ClearDatabaseAsync()
        {
            _context.TipoEventos.RemoveRange(_context.TipoEventos);
            await _context.SaveChangesAsync();
        }

        private readonly AppDbContext _context;
        private readonly TipoEventoRepository _repository;

        public TipoEventoRepositoryTest()
        {
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString()) // banco único a cada teste
                .Options;
            
            _context = new AppDbContext(options);
            _repository = new TipoEventoRepository(_context);
        }
    #endregion

    #region </Create>
        [Fact]
        public async Task CreateAsync_ShouldCreateTipoEvento()
        {
            // Arrange
            await ClearDatabaseAsync();
            var result = new TipoEventoEntity("Roupas");
            var token = new CancellationToken();
            
            // Act
            var response = await _repository.CreateAsync(result, token);
            
            // Assert
            Assert.NotNull(response);
            Assert.True(response.IsSuccess);
            Assert.Equal(201, response.Code);
        }
    #endregion

    #region </Delete>
        [Fact]
        public async Task DeleteAsync_ShouldRemoveTipoEvento_WhenExists()
        {
            // Arrange
            await ClearDatabaseAsync();
            var result = new TipoEventoEntity("Gadgets");
            var token = new CancellationToken();

            _context.TipoEventos.Add(result);
            await _context.SaveChangesAsync();
            _context.Entry(result).State = EntityState.Detached; // Simula um cenário real

            // Act
            var response = await _repository.DeleteAsync(result.Id, token);
            await _context.SaveChangesAsync();

            // Assert
            Assert.NotNull(response);
            Assert.True(response.IsSuccess);
            Assert.Equal(200, response.Code);

            var resultDb = await _context.TipoEventos.FindAsync(result.Id);
            Assert.Null(resultDb);
        }
    #endregion

    #region </GetAll>
        [Fact]
        public async Task GetAllAsync_ShouldReturnAllTipoEventos()
        {
            // Arrange
            await ClearDatabaseAsync();
            _context.TipoEventos.AddRange(
                new TipoEventoEntity("Eletrônicos"),
                new TipoEventoEntity("Casa e Decoração")
            );
            await _context.SaveChangesAsync();

            var token = new CancellationToken();
            
            // Act
            var response = await _repository.GetAllAsync(token);
            
            // Assert
            Assert.NotNull(response);
            Assert.True(response.IsSuccess);
            Assert.Equal(200, response.Code);
            Assert.NotNull(response.Data);
            Assert.Equal(2, response.Data.Count);  //Está dar erro nessa linha
        }
    #endregion

    #region </GetById>
        [Fact]
        public async Task GetByIdAsync_ShouldReturnTipoEvento_WhenExists()
        {
            // Arrange
            await ClearDatabaseAsync();
            var result = new TipoEventoEntity("Calçados");
            var token = new CancellationToken();
            _context.TipoEventos.Add(result);
            await _context.SaveChangesAsync();
            
            // Act
            var response = await _repository.GetByIdAsync(result.Id, token);
            
            // Assert
            Assert.NotNull(response);
            Assert.True(response.IsSuccess);
            Assert.Equal(200, response.Code);
        }
    #endregion

    #region </Update>
        [Fact]
        public async Task UpdateAsync_ShouldUpdateTipoEvento_WhenExists()
        {
            // Arrange
            await ClearDatabaseAsync();
            var result = new TipoEventoEntity("Acessórios");
            var token = new CancellationToken();
            _context.TipoEventos.Add(result);
            await _context.SaveChangesAsync();

            // Buscar a tipo de evento existente e modificar o nome
            var resultDb = await _context.TipoEventos.FindAsync(result.Id);
            Assert.NotNull(resultDb);
            resultDb.Update("Moda"); // Método no Entity para alterar o nome

            // Act
            var response = await _repository.UpdateAsync(resultDb, token);

            // Assert
            Assert.NotNull(response);
            Assert.True(response.IsSuccess);
            Assert.Equal(200, response.Code);

            var updatedResultDb = await _context.TipoEventos.FindAsync(result.Id);
            Assert.NotNull(updatedResultDb);
            Assert.Equal("Moda", updatedResultDb.Nome);
        }
    #endregion

    #region </Search>
        [Fact]
        public async Task SearchAsync_ShouldReturnMatchingTipoEventos()
        {
            // Arrange
            await ClearDatabaseAsync();
            _context.TipoEventos.AddRange(
                new TipoEventoEntity("Esportes"),
                new TipoEventoEntity("Jogos"),
                new TipoEventoEntity("Brinquedos")
            );
            await _context.SaveChangesAsync();

            var token = new CancellationToken();
            
            // Act
            var response = await _repository.SearchAsync(c => c.Nome.Contains("Jog"), "Categoria", token);
            
            // Assert
            Assert.NotNull(response);
            Assert.True(response.IsSuccess);
            Assert.Equal(200, response.Code);
            Assert.Equal("Jogos", response.Data?[0].Nome);
        }
    #endregion

    /*
     #region </GetAll>
        [Fact]
        public async Task GetAllAsyn_ShouldGetAllProduto()
        {
            _context.Produtos.AddRange(
                new ProdutoEntity("Ar Force", "Tenis da Nike", 2000, 1, "nike.png"),
                new ProdutoEntity("Ar Force 1", "Tenis da Nike", 2000, 1, "nike.png")
            );
            await _context.SaveChangesAsync();

            PagedRequest request = new PagedRequest{
                pageNumber = 1,
                pageSize = 10,
            };
            var response = _repository.GetAllAsync(request);

            Assert.NotNull(response);
            Assert.True(response.IsCompleted);

        }
    #endregion
    */
}
