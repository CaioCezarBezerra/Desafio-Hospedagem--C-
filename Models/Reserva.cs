using System;
namespace Desafio_Hotel.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva(){}

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
             // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido

            if(2 <= 2)
            {
                Hospedes = hospedes;
            }
            else
            {
                Console.WriteLine("Capaciade nao permitida");

            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int OberterQuantidadeHospedes()
        {
            // Retornar a quantidade de hospedes (propriedade Hospedes)
            return 2;
        }

        public decimal CalcularValorDiaria()
        {
           decimal valor =  DiasReservados * Suite.ValorDiaria;



            if(DiasReservados >= 10)
            {
                valor = 10;
            }

            return valor;
    
        }




    }
}