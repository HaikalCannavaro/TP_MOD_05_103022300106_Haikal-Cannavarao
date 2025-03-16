public class DataGeneric<T>
{
    private T data;

    public DataGeneric(T data)
    {
        this.data = data;
    }

    public void PrintData()
    {
        Console.WriteLine($"Data yang tersimpan adalah: {data}");
    }
}

class Program
{
    static void Main()
    {
        HaloGeneric halo = new HaloGeneric();
        halo.SapaUser("Haikal Cannavaro");

        DataGeneric<string> data = new DataGeneric<string>("103022300106");
        data.PrintData();

        Console.ReadKey();
    }
}
