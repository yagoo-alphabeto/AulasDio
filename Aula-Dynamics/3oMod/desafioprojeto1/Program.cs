using System.Text;
using desafioprojeto1.Models;


Console.OutputEncoding = Encoding.UTF8;

List<Pessoa> hospedes = new List<Pessoa>();


Pessoa p1 = new Pessoa(nome: "Hospede 1");
Pessoa p2 = new Pessoa(nome: "Hospede 2");
Pessoa p3 = new Pessoa(nome: "Hospede 3");
Pessoa p4 = new Pessoa(nome: "Hospede 4");

hospedes.Add(p1);
hospedes.Add(p2);
hospedes.Add(p3);
hospedes.Add(p4);


Suite suite1 = new Suite(tipoSuite: "Premium", capacidade: 3, valorDiaria: 120);

Reserva reserva = new Reserva(diasReservados: 10);
reserva.CadastrarSuite(suite1);
reserva.CadastrarHospedes(hospedes);


Console.WriteLine($"Hospedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor Diaria: {reserva.CalcularValorDiaria()}");




