using pessoaAPI.Models;

namespace wstesteFull.DAO
{
    public class PessoaDAO
    {
        //CRUD no banco de dados de pessoas

        public bool Inserir(Pessoa pessoa)
        {
            string query = "insert into pessoa values(,,,,)";

            return true;
        }
    }
}