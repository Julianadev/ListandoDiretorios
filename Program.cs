internal class Program
{
  private static void Main(string[] args)
  {
    Console.Clear();
    Console.WriteLine("-----------------------------");
    Console.WriteLine("Explorer de Arquivos");
    // Define o caminho do diretório a ser percorrido
    Console.WriteLine("Digite o caminho do arquivo: ");
    string? path = Console.ReadLine();
    string? rootDirectory = path;

    // Chama a função RecursiveDirectorySearch para percorrer o diretório e seus subdiretórios
    RecursiveDirectorySearch(rootDirectory);
  }

  static void RecursiveDirectorySearch(string directory)
  {
    // Exibe o nome do diretório atual
    Console.WriteLine(directory);

    // Obtém a lista de arquivos no diretório atual
    string[] files = Directory.GetFiles(directory);

    // Exibe o nome de cada arquivo
    foreach (string file in files)
    {
      Console.WriteLine("  " + file);
    }

    // Obtém a lista de subdiretórios no diretório atual
    string[] subdirectories = Directory.GetDirectories(directory);

    // Chama a função RecursiveDirectorySearch para cada um dos subdiretórios
    foreach (string subdirectory in subdirectories)
    {
      RecursiveDirectorySearch(subdirectory);
    }
  }
}
