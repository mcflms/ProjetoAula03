using Dapper;
using ProjetoAula03.Entities;
using ProjetoAula03.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula03.Repositories
{
    // <summary>
    /// Classe para repositorio de dados para a entidade Funcionario
    /// </summary>
    public class FuncionarioRepository : IBaseRepository<Funcionario>
    {
        //atributo
        private readonly string _connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BDAula03;
        Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;
        Multi Subnet Failover=False";
        public void Create(Funcionario obj)
        { //Escrevendo o comando SQL
            var sql = @"
                      INSERT INTO FUNCIONARIO(ID, NOME, MATRICULA, CPF, DATAADMISSAO, EMPRESAID)
                      VALUES(@Id, @Nome, @Matricula, @Cpf, DataAdimissao, EmpresaId)
                       ";

            //abrindo conexão com o SQLSERVER
            using (var connection = new SqlConnection(_connectionString))
            {
                //Executando o comando com  Dapper (Execute) e um comando Dapper
                connection.Execute(sql, obj);
            }



        }
        public void Delete(Funcionario obj)
        {
            var sql = @"
                     DELETE FROM FUNCIONARIO                                                
                     WHERE ID = @Id
                        
                      ";
            using (var connections = new SqlConnection(_connectionString))
            {
                connections.Execute(sql, obj);
            }
        }

        public List<Funcionario> GetAll()
        {
            var sql = @"
                     SELECT * FROM FUNCIONARIO
                     ORDER BY
                          NOME ASC                        
                      ";

            using (var connections = new SqlConnection(_connectionString))
            {
               return connections.Query<Funcionario>(sql).ToList();
            }
        }

        public void Update(Funcionario obj)
        {
            var sql = @"
                        UPDATE FUNCIONARIO SET
                        NOME = @Nome,
                        MATRICULA = @Matricula,
                        CPF = @Cpf,
                        DATAADMISSAO = @DataAdmissao,
                        EMPRESAID = @EmpresaId
                     WHERE
                        ID = @Id
                        
                        ";
            using (var connections = new SqlConnection(_connectionString))
            {
                connections.Execute(sql, obj);
            }
        }



}   }   
