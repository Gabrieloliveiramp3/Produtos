using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Produto
{
    public string Nome;
    public double Preco;
    public int Estoque;

    public Produto()
    {
    }

    public Produto(string nome, double preco)
    {
        Nome = nome;
        Preco = preco;
        Estoque = 0;
    }

    public int Vender(int qtde)
    {
        if (Estoque - qtde >= 0)

        Estoque -= qtde;
        Console.WriteLine($"Venda de {qtde} {Nome}s realizada com sucesso");
        return Estoque;
        
    }

    public int Comprar(int qtde)
    {
        Estoque += qtde;
        Console.WriteLine($"Compra de {qtde} {Nome}s realizada com sucesso");
        return Estoque;
    }
    public string ObterResumo()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Nome : {Nome}");
        sb.AppendLine($"Preco : {Preco}");
        sb.AppendLine($"Estoque : {Estoque}");
        return sb.ToString();
        
    }
}