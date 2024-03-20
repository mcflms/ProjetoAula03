using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula03.Entities

    ///<summary>
    ///Classe de Entidade
    ///</summary>
{
    public class Empresa
    {
        public Guid Id { get; set; }
        public string NomeFantasia { get; set; }
        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }

        //Associação de um para muitos, ou seja, de uma Empresa para muitos Funcionarios. 
        #region Associações
        public List<Funcionario> Funcionarios { get; set; }
        #endregion
    }


}
