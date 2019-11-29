using System.IO;
using project_RoleTopMVC.Models;

namespace project_RoleTopMVC.Respositories
{
    public class ClienteRepository : RepositoryBase
    {
        private const string PATH = "Database/Cliente.csv";
        public ClienteRepository()
        {
            if (!File.Exists(PATH)){
                File.Create(PATH).Close();
            }
        }
        public bool Inserir(Cliente cliente)
        {
            var dadosCliente = new string[] {PrepararRegistroCSV(cliente)};
            File.AppendAllLines(PATH , dadosCliente);
            return true;
        }
        public Cliente ObterPor(string email)
        {
            var clientes = File.ReadAllLines(PATH);
            foreach(var cliente in clientes)
            {
                if(ExtrairValorDoCampo("email", cliente).Equals(email))
                {
                    Cliente c = new Cliente();
                    c.TipoUsuario = uint.Parse(ExtrairValorDoCampo("tipo_usuario", cliente));
                    c.Nome = ExtrairValorDoCampo ("nome", cliente);
                    c.Email = ExtrairValorDoCampo("email", cliente);
                    c.Senha = ExtrairValorDoCampo("senha", cliente);
                    c.Telefone = ExtrairValorDoCampo("telefone", cliente);
                    c.Endereco = ExtrairValorDoCampo("endereco", cliente);
                    c.CEP = ExtrairValorDoCampo("cep", cliente);
                    c.CpfCnpj = ExtrairValorDoCampo("cpfcnpj", cliente);
                    c.Complemento = ExtrairValorDoCampo("complemento", cliente);
                    return c;
                }
            }
            return null;
        }
        private string PrepararRegistroCSV(Cliente cliente)
        {
            return $"tipo_usuario={cliente.TipoUsuario};nome={cliente.Nome};email={cliente.Email};senha={cliente.Senha};telefone={cliente.Telefone};endereco={cliente.Endereco}; cep={cliente.CEP};cpfcnpj={cliente.CpfCnpj};complemento={cliente.Complemento}";
        }
    }
}