
using System.Text;
using Desafio_Hotel.Models;

Console.OutputEncoding = Encoding.UTF8;


//Cria os modelos de hospedes e cadastra na lista de hospedes


List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Hospede 1");
Pessoa p2 = new Pessoa(nome: "Hospede 2");

hospedes.Add(p1);
hospedes.Add(p2);

//Cria a suite

Suite suite = new Suite(tipoSuite: "Premium", capacidade: 3, valorDiaria: 30);

//Cria uma nova reserva, passando a suite e os hospedes

Reserva reserva = new Reserva(diasReservados: 10);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);


//Exiber a quantidade de hospedes e o valor da diaria 

Console.WriteLine($"Hospedes: {reserva.OberterQuantidadeHospedes()}");
Console.WriteLine($"Valor diaria: {reserva.CalcularValorDiaria()}");


