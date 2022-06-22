namespace aprendendoConjunts
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Dictionary<string, string> infLogin = new Dictionary<string, string>();

            int i = 0;

            while (i == 0)
            {
                Console.WriteLine($"Olá, digite o que deseja fazer: " + Environment.NewLine +
                    $"1 - Cadastrar usuário" + Environment.NewLine +
                    $"2 - Mostrar os usuários criados e senhas"+  Environment.NewLine +
                    $"3 - Sair do Loop");
                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {

                    case 1:
                        Console.WriteLine("Olá! Seja bem-vindo! Digite suas informações abaixo: ");
                        Console.Write("E-mail: ");
                        string email = Console.ReadLine();
                        Console.Write("Username: ");
                        string username = Console.ReadLine();
                        Console.Write("Telefone celular: ");
                        long telefone = long.Parse(Console.ReadLine());
                        Console.Write("Senha: ");
                        string senha = Console.ReadLine();
                        Console.Clear();

                        User usuario = new User()
                        {
                            UserName = username,
                            Email = email,
                            Password = senha,
                            Phone = telefone,
                        };

                        infLogin.Add(usuario.UserName, usuario.Password);
                        break;
                    case 2:
                        foreach (KeyValuePair<string, string> item in infLogin)
                        {
                            Console.WriteLine($"Username: {item.Key} - Password: {item.Value}");
                        }
                        break;
                    case 3:
                        i = 1;
                        break;
                    default:
                        Console.WriteLine("Digite uma opção válida entre 1 e 3");
                        break;
                }
            }

        }
    }
}