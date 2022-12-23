internal class Program
{
  private static void Main(string[] args)
  {


    //menu
    Console.WriteLine("1 - Listar arquivos e diretórios");
    Console.WriteLine("2 - Criar diretório");
    Console.WriteLine("3 - Deletar diretório");
    Console.WriteLine("4 - Copiar arquivo");
    Console.WriteLine("5 - Mover arquivo");
    Console.WriteLine("0- Sair");
    Console.WriteLine("Digite a opção desejada: ");
    short opcao = short.Parse(Console.ReadLine());

    switch (opcao)
    {
      case 1:
        ListarArquivos();
        break;
      case 2:
        CriarDiretorio();
        break;
      case 3:
        DeletarDiretorio();
        break;
      case 4:
        CopiarArquivo();
        break;
      case 5:
        MoverArquivo();
        break;
      case 0:
        System.Environment.Exit(0);
        break;
      default:
        Console.WriteLine("Opção inválida");
        break;
    }
  }

  private static void ListarArquivos()
  {
    // caminho do diretório que deseja listar os subdiretórios
    string path = @"C:\Users\jully\OneDrive\Documentos";

    // cria um objeto do tipo DirectoryInfo para o diretório informado
    DirectoryInfo directoryInfo = new DirectoryInfo(path);

    // obtém os subdiretórios do diretório informado
    DirectoryInfo[] dirs = dirs = directoryInfo.GetDirectories();

    // percorre os subdiretórios e exibe o nome de cada um deles
    foreach (DirectoryInfo subdir in dirs)
    {
      Console.WriteLine(subdir.Name);
    }

    // diretorio esoecífico
    DirectoryInfo[] dirs2 = directoryInfo.GetDirectories();
    // imprime a lista de subdiretórios
    foreach (DirectoryInfo subdir in dirs2)
    {
      Console.WriteLine(subdir.FullName);
    }
    //obtem os arquivos do diretório atual
    FileInfo[] files = directoryInfo.GetFiles();
    // imprime a lista de arquivos
    foreach (FileInfo file in files)
    {
      Console.WriteLine(file.FullName);
    }

    Console.WriteLine("Pressione qualquer tecla para continuar...");
    Console.ReadKey();

  }

  private static void CriarDiretorio()
  {
    Console.WriteLine("Digite o nome do diretório: ");
    string nome = Console.ReadLine();

    // caminho do diretório que deseja criar
    string path = @"C:\Users\jully\OneDrive\Documentos\" + nome;

    // cria um objeto do tipo DirectoryInfo para o diretório informado
    DirectoryInfo directoryInfo = new DirectoryInfo(path);

    // verifica se o diretório já existe
    if (directoryInfo.Exists)
    {
      Console.WriteLine("O diretório já existe");
    }
    else
    {
      // cria o diretório
      directoryInfo.Create();
      Console.WriteLine("Diretório criado com sucesso");
    }

    Console.WriteLine("Pressione qualquer tecla para continuar...");
    Console.ReadKey();
  }

  private static void DeletarDiretorio()
  {
    Console.WriteLine("Digite o nome do diretório: ");
    string nome = Console.ReadLine();
    // caminho do diretório que deseja criar
    string path = @"C:\Users\jully\OneDrive\Documentos\" + nome;

    // cria um objeto do tipo DirectoryInfo para o diretório informado
    DirectoryInfo directoryInfo = new DirectoryInfo(path);

    // verifica se o diretório já existe
    if (directoryInfo.Exists)
    {
      // deleta o diretório
      directoryInfo.Delete();
      Console.WriteLine("Diretório deletado com sucesso");
    }
    else
    {
      Console.WriteLine("O diretório não existe");
    }

    Console.WriteLine("Pressione qualquer tecla para continuar...");
    Console.ReadKey();
  }

  private static void CopiarArquivo()
  {
    Console.WriteLine("Digite o nome do arquivo: ");
    string nome = Console.ReadLine();

    // caminho do arquivo que deseja copiar
    string path = @"C:\Users\jully\OneDrive\Documentos\" + nome;
    Console.WriteLine("Digite o caminho do diretorio para onde deseja copiar: ");
    string path2 = Console.ReadLine();

    // caminho do diretório que deseja criar
    string path3 = @"C:\Users\jully\OneDrive\Documentos\" + path2;

    // cria um objeto do tipo FileInfo para o arquivo informado
    FileInfo fileInfo = new FileInfo(path);

    // cria um objeto do tipo DirectoryInfo para o diretório informado
    DirectoryInfo directoryInfo = new DirectoryInfo(path2);

    // verifica se o arquivo existe

    if (fileInfo.Exists)
    {
      // copia o arquivo para o diretório informado
      fileInfo.CopyTo(directoryInfo.FullName + "\\" + fileInfo.Name, true);
      Console.WriteLine("Arquivo copiado com sucesso");
    }
    else
    {
      Console.WriteLine("O arquivo não existe");
    }

    Console.WriteLine("Pressione qualquer tecla para continuar...");
    Console.ReadKey();
  }

  private static void MoverArquivo()
  {
    Console.WriteLine("Digite o nome do arquivo: ");
    string nome = Console.ReadLine();

    // caminho do arquivo que deseja copiar
    string path = @"C:\Users\jully\OneDrive\Documentos\" + nome;

    Console.WriteLine("Digite o caminho do diretorio para onde deseja mover: ");
    string path2 = Console.ReadLine();
    // caminho do diretório que deseja criar
    string path3 = @"C:\Users\jully\OneDrive\Documentos\" + path2;

    // cria um objeto do tipo FileInfo para o arquivo informado
    FileInfo fileInfo = new FileInfo(path);

    // cria um objeto do tipo DirectoryInfo para o diretório informado
    DirectoryInfo directoryInfo = new DirectoryInfo(path2);

    // verifica se o arquivo existe

    if (fileInfo.Exists)
    {
      // copia o arquivo para o diretório informado
      fileInfo.MoveTo(directoryInfo.FullName + "\\" + fileInfo.Name);
      Console.WriteLine("Arquivo movido com sucesso");
    }
    else
    {
      Console.WriteLine("O arquivo não existe");
    }

    Console.WriteLine("Pressione qualquer tecla para continuar...");
    Console.ReadKey();
  }
}
