namespace Calculadora.Services;

public class CalculadoraImp
{
    private List<string> listahistorico;
    private DateTime data;

    public CalculadoraImp()
    {
        listahistorico = new List<string>();
        data = DateTime.Now;
    }

    public int Somar(int num1, int num2)
    {
        int res = num1 + num2;
        listahistorico.Insert(0, "Res: " + res);
        return res;
    }

    public int Subtrair(int num1, int num2)
    {
        int res = num1 - num2;
        listahistorico.Insert(0, "Res: " + res);
        return res;
    }

    public int Multiplicar(int num1, int num2)
    {
        int res = num1 * num2;
        listahistorico.Insert(0, "Res: " + res);
        return res;
    }

    public int Dividir(int num1, int num2)
    {
        int res = num1 / num2;
        listahistorico.Insert(0, "Res: " + res);
        return res;
    }

    public List<string> historico()
    {
        listahistorico.RemoveRange(3, listahistorico.Count - 3);
        return listahistorico;
    }

    public void mostrarData()
    {
        Console.WriteLine($"Data: {data.ToString()}");
    }
}
