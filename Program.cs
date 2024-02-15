class MainClass 
{
    public static void Main(string[] args) 
    {
        Produto p1 = new();
        p1.Nome = "Abacaxi";
        p1.Preco = 3.8;
        p1.Comprar(40);
        Console.WriteLine(p1.ObterResumo());
        


        Produto p2 = new("Melancia", 4.5);
        p2.Comprar(70);
        Console.WriteLine(p2.ObterResumo());

        Produto p3 = new("Goiaba", 7.8);
        p3.Comprar(90);
        p3.Vender(30);
        Console.WriteLine(p3.ObterResumo());

    }
}