namespace ClassLibrary1
{
  internal class Program
  {
    public static void Main()
    {
      IFile json = new JsonFile2();
      IFile csv = new CsvFile2();
      var data = csv.Load();
      json.Save(data);

      // while (true)
      // {
      //   Console.WriteLine("1 - pracovat s csv, 2 - pracovat s json");
      //   string key = Console.ReadKey().KeyChar.ToString();
      //   Console.WriteLine("\n");
      //   if (key.Equals("1"))
      //   {
      //     new CsvFile();
      //     break;
      //   }
      //   if (key.Equals("2"))
      //   {
      //     new JsonFile();
      //     break;
      //   }
      //   Console.WriteLine("Špatně zadáno");
      // }
    }
  }
}