namespace Kairos.Test.UnityTests.Entities;
public class TipoEventosEntityTest
{
    #region <Constants>
        private const int InvalidNumberZero = 0;
        private const int InvalidNumber = -1;
        private const string ValidName = "Test0";
    #endregion

    #region <Id>
        [Theory]
        [InlineData(InvalidNumber, ValidName)]
        [InlineData(InvalidNumberZero, ValidName)]
        public void ShouldFailTipoEventoIfIdIsNegative(int id, string nome)
        {
            Assert.True(true); 
            Assert.Throws<DomainExceptionValidation>(() =>
            {
                var acount = new TipoEventoEntity(id, nome);
            });
        }
    #endregion

    #region <Nome>
        [Theory]
        [InlineData("")]
        [InlineData(null)]
        [InlineData(" ")]
        public void ShouldFailIfTipoEventoNameIsNullOrEmptyOrWhiteSpace(string nome)
        {
            Assert.True(true); 
            Assert.Throws<DomainExceptionValidation>(() =>
            {
                var acount = new TipoEventoEntity(nome);
            });
        }
    #endregion

    #region <LongLenght>
        [Fact]
        public void ShouldFailIfIsHaveLongLenght()
        {
            var LongLenght = new string('B', 61);
            Assert.True(true); 
            Assert.Throws<DomainExceptionValidation>(() =>
            {
                var acount = new TipoEventoEntity(LongLenght);
            });
        }
    #endregion

    #region <Criar>
        [Theory]
        [InlineData(ValidName)]
        public void ShouldCreate(string nome)
        {
            var count = new TipoEventoEntity(nome);
            Assert.NotNull(count);
        }
    #endregion

    #region <Editar>
        [Theory]
        [InlineData(ValidName)]
        public void ShouldEdit(string nome)
        {
            var count = new TipoEventoEntity(nome);
            count.Update("Test");
            Assert.Equal("Test", count.Nome);
        }
    #endregion
}
