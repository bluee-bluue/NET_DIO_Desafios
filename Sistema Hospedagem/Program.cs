using DesafioProjeto_SistemaDeHospedagem.Models;

namespace DesafioProjeto_SistemaDeHospedagem;

public static class Program
{
    public static void Main()
    {
        List<Pessoa> hospedes = new List<Pessoa>();

        Pessoa p1 = new Pessoa("Hospede 1");
        Pessoa p2 = new Pessoa("Hospede 2");

        hospedes.Add(p1);
        hospedes.Add(p2);

        Suite suite = new Suite("Premium", 3, 30);

        Reserva reserva = new Reserva(15);
        reserva.CadastrarSuite(suite);
        reserva.CadastrarHospedes(hospedes);

        Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
        Console.WriteLine($"Valor da diária: {reserva.CalcularValorDiaria()}");
    }
}