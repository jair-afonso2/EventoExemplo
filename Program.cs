using System;

namespace EventoExemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro(10, "5872");
            carro.TanqueVazio += new Carro.EventoCarro(tanque_vazio);
            carro.TanqueVazio += new Carro.EventoCarro(ligar_uber);
            carro.Ligacao += new Carro.Chamar(ligar_casa);
            carro.Ligar();
        }

        static void tanque_vazio()
        {
            System.Console.WriteLine("Tanque Vazio");
        }

        static void ligar_uber()
        {
            System.Console.WriteLine("Uber");
        }

        static void ligar_casa(string telefone)
        {
            System.Console.WriteLine("Telefone: " + telefone);
        }
    }
}