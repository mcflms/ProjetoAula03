using ProjetoAula03.Entities;
using ProjetoAula03.Repositories;
using System;

namespace projetoAula03
{
    class progam
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n *** CONTROLE DE EMPRESAS *** \n");
            try
            {
                Console.WriteLine("(1) CADASTRAR EMPRESA");
                Console.WriteLine("(2) ATUALIZAR EMPRESA");
                Console.WriteLine("(3) EXCLUIR EMPRESA");
                Console.WriteLine("(4) CONSULTAR EMPRESA");

                Console.WriteLine("Informe a opção desejada...:");
                var opcao = int.Parse(Console.ReadLine());

                if (opcao ==1)
                {
                    Console.Write("\nCADASTRO DE EMPRESA:\n");

                    var empresa = new Empresa();
                    empresa.Id = Guid.NewGuid();

                    Console.Write("Informe o Nome Fantasia......:");
                    empresa.NomeFantasia = Console.ReadLine();

                    Console.Write("Informe a Razão Social.......:");
                    empresa.NomeFantasia = Console.ReadLine();

                    Console.Write("Informe o CNPJ...............:");
                    empresa.NomeFantasia = Console.ReadLine();

                    var empresaRepository = new EmpresaRepository();    
                    empresaRepository.Create(empresa);

                    Console.WriteLine("\nEMPRESA CADASTRADA COMSUCESSO!\n");

                }

            }
            catch (Exception e)
            {

                Console.WriteLine ($"\nERRO: {e.Message}");
            }
            Console.ReadKey();

        }

  
    }
}


