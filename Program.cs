using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Hóspede 1");
Pessoa p2 = new Pessoa(nome: "Hóspede 2");
Pessoa p3 = new Pessoa(nome: "Hóspede 3");
Pessoa p4 = new Pessoa(nome: "Hóspede 4");
Pessoa p5 = new Pessoa(nome: "Hóspede 5");
Pessoa p6 = new Pessoa(nome: "Hóspede 6");
Pessoa p7 = new Pessoa(nome: "Hóspede 7");
Pessoa p8 = new Pessoa(nome: "Hóspede 8");
Pessoa p9 = new Pessoa(nome: "Hóspede 9");
Pessoa p10 = new Pessoa(nome: "Hóspede 10");

hospedes.Add(p1);
hospedes.Add(p2);

List<Pessoa> hospedesDeluxe = new List<Pessoa>();
hospedesDeluxe.Add(p3);
hospedesDeluxe.Add(p4);
hospedesDeluxe.Add(p5);
hospedesDeluxe.Add(p6);
hospedesDeluxe.Add(p7);
hospedesDeluxe.Add(p8);
hospedesDeluxe.Add(p9);
hospedesDeluxe.Add(p10);

// Cria as suítes
Suite suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 30);
Suite suiteDeluxe = new Suite("Deluxe", 10, 1000);

// Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reserva = new Reserva(diasReservados: 2);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

// Reserva para a suite deluxe
Reserva deluxe = new Reserva(diasReservados: 10);
deluxe.CadastrarSuite(suite: suiteDeluxe);
deluxe.CadastrarHospedes(hospedes: hospedesDeluxe);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine("--- Reserva para a suíte Premium ---");
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria().ToString("C")}");

Console.WriteLine("--- Reserva para a suíte Deluxe ---");
Console.WriteLine($"Hóspedes: {deluxe.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {deluxe.CalcularValorDiaria().ToString("C")}");