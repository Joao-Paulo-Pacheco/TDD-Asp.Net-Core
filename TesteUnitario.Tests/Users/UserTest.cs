using Moq;
using System.Threading.Tasks;
using TesteUnitario.Repository;
using TesteUnitario.Tests.Users.Fakes;
using TesteUnitario.Tests.Users.Fixtures;
using TesteUnitario.Tests.Users.TestsDoubles.Dummys;
using TesteUnitario.Tests.Users.TestsDoubles.Moqs;
using TesteUnitario.Tests.Users.TestsDoubles.Spies;
using TesteUnitario.Tests.Users.TestsDoubles.Stubs;
using TesteUnitario.Users;
using Xunit;

namespace TesteUnitario.Tests.Users
{
    public class UserTest
    {
        private readonly Mock<IUserRepository> _userRepositoryMock;

        public UserTest()
        {
            _userRepositoryMock = new Mock<IUserRepository>();
        }

        #region DUMMY

        [Fact]
        public async Task Authenticate_UserNotExists_ReturnFalse()
        {
            //Arrage
            string useraname = "Teste";
            string password = "Teste";


            //Um objeto dummy é usado apenas para preencher a assinatura de um método,
            //mas não tem um papel significativo no teste. Ele pode ser uma instância vazia
            //ou com valores padrão.

            //Objeto DUMMY
            var repository = new UserRepositoryDummy();

            //Usando DUMMY
            var service = new UserService(repository);

            //Act
            var result = await service.Authenticate(useraname, password);

            //Assert
            Assert.False(result);
        }
        #endregion

        #region STUB

        [Fact]
        public async Task Authenticate_LoginIsInvalid_ReturnFalse()
        {
            //Arrage
            string useraname = "Teste";
            string password = "Teste";

            //Um stub fornece respostas pré-definidas a chamadas de métodos durante
            //o teste. Ele simula um comportamento específico para garantir que o
            //teste ocorra de maneira controlada.

            //Criando Stub
            var repository = new UserRepositoryStub();
            // Usando Stub
            var service = new UserService(repository);

            //Act
            var result = await service.Authenticate(useraname, password);

            //Assert
            Assert.False(result);
        }
        #endregion

        #region SPY

        [Fact]
        public async Task Authenticate_ParamsIsCorrect_ReturnTrue()
        {
            //Arrage
            string username = "Teste";
            string password = "Teste";

            //Um spy é semelhante a um mock, mas geralmente é usado para gravar
            //informações sobre o comportamento do sistema sob teste sem alterar
            //esse comportamento.


            //Criando Spy
            var repository = new UserRepositorySpy();
            repository.SetResult(true);
            // Usando Spy
            var service = new UserService(repository);

            //Act
            var result = await service.Authenticate(username, password);

            //Assert
            Assert.True(result);
            Assert.Equal(username, repository.GetUserName());
            Assert.Equal(password, repository.GetPassword());
            Assert.Equal(1, repository.GetCount());
        }
        #endregion

        #region MOCK

        [Fact]
        public async Task Authenticate_ParamsIsCorrectWithMock_ReturnTrue()
        {
            //Arrage
            string username = "Teste";
            string password = "Teste";

            //Um mock é um objeto que grava chamadas de métodos feitas durante um
            //teste para posterior verificação. Ele permite verificar se certos
            //métodos foram chamados com os argumentos corretos.


            //Criando MOck
            var repository = new UserRepositoryMock(username, password, 1);
            repository.SetResult(true);
            // Usando Mock
            var service = new UserService(repository);

            //Act
            var result = await service.Authenticate(username, password);

            //Assert
            Assert.True(result);
            Assert.True(repository.Validate());
        }
        #endregion

        #region MOQ

        [Fact]
        public async Task Authenticate_ParamsIsCorrectWithMoq_ReturnTrue()
        {
            //Arrage
            string username = "Teste";
            string password = "Teste";

            //MOQ é uma biblioteca que facilita na criação de mocks

            //Configurando função GetUserByUserName e Authenticate do userRepositoryMock
            _userRepositoryMock.Setup(x => x.GetUserByUserName(username)).ReturnsAsync(new User());
            _userRepositoryMock.Setup(x => x.Authenticate(username, password)).ReturnsAsync(true);

            // Usando Moq
            var service = new UserService(_userRepositoryMock.Object);

            //Act
            var result = await service.Authenticate(username, password);

            //Assert
            Assert.True(result);
        }
        #endregion

        #region FAKE
        [Fact]
        public async Task Authenticate_CredentialIsValid_ReturnTrue()
        {
            //Arrange
            var username = "user";
            var password = "12345";
            var fake = new UserRepositoryFake();
            var service = new UserService(fake);

            // Act
            var result = await service.Authenticate(username, password);

            //Assert
            Assert.True(result);
        }

        [Fact]
        public async Task Authenticate_CredentialIsNotValid_ReturnFalse()
        {
            //Arrange
            var username = "user";
            var password = "4123";
            var fake = new UserRepositoryFake();
            var service = new UserService(fake);

            // Act
            var result = await service.Authenticate(username, password);

            //Assert
            Assert.False(result);
        }
        #endregion

        #region FAKER
        [Fact]
        public async Task Add_UserValid_ReturnTrue()
        {
            //Arrange
            var username = "user";
            var password = "12345";

            _userRepositoryMock.Setup(x => x.GetUserByUserName(username)).ReturnsAsync(new User());
            _userRepositoryMock.Setup(x => x.Add(It.IsAny<User>())).ReturnsAsync(true);
            var service = new UserService(_userRepositoryMock.Object);
            var model = UserFixture.GetUserValid();

            //Act
            var result = await service.Add(model);

            //Assert
            Assert.True(result);
        }
        #endregion

    }
}
