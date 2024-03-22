using ProjetoAula03.Entities;
using ProjetoAula03.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula03.Repositories
{
    /// <summary>
    /// Classe para repositorio de dados para a entidade Empresa
    /// </summary>
    public class EmpresaRepository : IBaseRepository<Empresa>
    {
        public void Create(Empresa obj)
        {
            using (var connection = new SqlConnection())
            {
                connection.Open();                                                                                                                                                                                                                                                      

            }
        }

        public void Delete(Empresa obj)
        {
            throw new NotImplementedException();
        }

        public List<Empresa> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Empresa obj)
        {
            throw new NotImplementedException();
        }
    }
}
