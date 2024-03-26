using Dapper;
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
        //atributo
        private readonly string _connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BDAula03;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
        public void Create(Empresa obj)
        {   //Escrevendo o comando SQL
            var sql = @"
                      INSERT INTO EMPRESA(ID, RAZAOSOCIAL, NOMEFANTASIA, CNPJ)
                      VALUES(@Id, @RazaoSocial, @NomeFantasia, @Cnpj)
                       ";

            //abrindo conexão com o SQLSERVER
            using (var connection = new SqlConnection(_connectionString)) 
            {
                //Executando o comando com  Dapper (Execute) e um comando Dapper
                connection.Execute(sql, obj);
                                                                                                                                                                                                                                                                     

            }
        }

        public void Delete(Empresa obj)
        {
            //escrevendo o comando SQL
            var sql = @"
                             DELETE FROM EMPRESA
                             WHERE ID = @Id
                          ";

            //abrindo conexão com o SQLSERVER
            using (var connection = new SqlConnection(_connectionString))
            {
                //executando o comando com o Dapper
                connection.Execute(sql, obj);   

            }
        }

        public List<Empresa> GetAll()
        {
            //escrevendo o comando SQL
            var sql = @"
                      SELECT * FROM EMPRESA
                      ORDER BY
                          NOMEFANTASIA ASC
                      
                      ";

            //abrindo conexão com o SQLSERVER
            using (var connection = new SqlConnection(_connectionString))
            {
                //Executando o comando com o Dapper, e retornando o resultado
                return connection.Query<Empresa>(sql).ToList();
            }
        }

        public void Update(Empresa obj)
        {
           
            //escrevendo o comando SQL
            var sql = @"
                    UPDATE EMPRESA SET
                       RAZAOSOCIAL = @RazaoSocial,
                       NOMEFANTASIA = @NomeFantasia,
                       CNPJ = @Cnpj
                    WHERE
                        ID = @id
                 ";
            //abrindo conexão com o SQLSERVER
            using (var connection = new SqlConnection(_connectionString))
            {
               
                //executando o comando com o Dapper
                connection.Execute(sql, obj);
               

            }
        }
    }
}
