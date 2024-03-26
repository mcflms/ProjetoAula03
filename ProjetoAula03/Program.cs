using ProjetoAula03.Entities;
using ProjetoAula03.Repositories;
using System;




namespace projetoAula03
{
    class progam
    {
        private static object confirmacao;

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

                if (opcao == 1)
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

                    Console.WriteLine("\nEMPRESA CADASTRADA COM SUCESSO!\n");

                }
                else if (opcao == 2)
                {
                    Console.Write("\nATUALIZAÇÃO DE EMPRESA:\n");

                    var empresa = new Empresa();

                    Console.Write("Informe o ID da Empresa......:");
                    empresa.Id = Guid.Parse(Console.ReadLine());

                    Console.Write("Informe o Nome Fantasia......:");
                    empresa.NomeFantasia = Console.ReadLine();

                    Console.Write("Informe a Razão Social.......:");
                    empresa.NomeFantasia = Console.ReadLine();

                    Console.Write("Informe o CNPJ...............:");
                    empresa.NomeFantasia = Console.ReadLine();

                    var empresaRepository = new EmpresaRepository();
                    empresaRepository.Update(empresa);

                    Console.WriteLine("\nEMPRESA CADASTRADA COM SUCESSO!\n");


                }
                else if (opcao == 3)
                {
                    Console.Write("\nEXCLUSÃO DE EMPRESA:\n");

                    var empresa = new Empresa();

                    Console.Write("Informe o ID da Empresa......:");
                    empresa.Id = Guid.Parse(Console.ReadLine());

                    
                    var empresaRepository = new EmpresaRepository();
                    empresaRepository.Delete(empresa);

                    Console.WriteLine("\nEMPRESA EXCLUIDA COM SUCESSO!\n");


                }
                else if(opcao ==4)
                {
                    Console.WriteLine("\nCONSULTA DE EMPRESAS:!\n");

                    var empresaRepository = new EmpresaRepository();
                    var empresas = empresaRepository.GetAll();

                    //Imprimindo os Dados das empresas
                    foreach (var item in empresas)
                    {
                        Console.WriteLine($"ID............: {item.Id}");
                        Console.WriteLine($"NOME FANTASIA.: {item.NomeFantasia}");
                        Console.WriteLine($"RAZÃO SOCIAL..: {item.RazaoSocial}");
                        Console.WriteLine($"CNPJ..........: {item.Cnpj}");
                        Console.WriteLine("===");
                    }
                    Console.WriteLine("\nDeseja Continuar? (S,N): ");
                    var confirmãcao = Console.ReadLine();

                    if (confirmacao.Equals("S"))
                    {
                        Console.Clear(); //limpar o console
                        Main(args); //recursividade
                    }
                    Console.WriteLine("/n FIM!");

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


