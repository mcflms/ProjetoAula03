using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula03.Entities
{
    /// <summary>
    /// Classse de Entidade
    /// </summary>
    public class Funcionario
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Matricula { get; set; }
        public int Cpf { get; set; }
        public DateTime DataAdmissao { get; set; }
        public Guid EmpresaId { get; set; }

        //Associação de muitos para um, ou seja de Funcionarios a Empresa. 
        #region Assiciações
        public Empresa Empresa { get; set; }

        #endregion
    }
}
