namespace DesafioProjeto_SistemaDeHospedagem.Models;

public class Reserva
{
    public List<Pessoa> Hospedes { get; set; }
    public Suite Suite { get; set; }
    public int DiariasReservadas { get; set; }
    
    public Reserva() { }

    public Reserva(int diariasReservadas)
    {
        DiariasReservadas = diariasReservadas;
    }

    public void CadastrarHospedes(List<Pessoa> hospedes)
    {
        // verificar se a capaciedade é maior ou igual ao número de hóspedes sendo recebido
        if (Suite.Capacidade >= hospedes.Count)
        {
            Hospedes = hospedes;
        }
        else
        {
            throw new Exception("A capacidade da suite é menor que o número de hospedes");
        }
    }
    
    public void CadastrarSuite(Suite suite)
    {
        Suite = suite;
    }
    
    public int ObterQuantidadeHospedes()
    {
        return Hospedes.Count;
    }
    
    public decimal CalcularValorDiaria()
    {
        decimal valor = 0;

        if (DiariasReservadas >= 10)
        {
            decimal valorOriginal = DiariasReservadas * Suite.ValorDiaria;
            valor = valorOriginal - (valorOriginal * 10/100);
        }
        else
        {
            valor = DiariasReservadas * Suite.ValorDiaria;
        }
        
        return valor;
    }
}