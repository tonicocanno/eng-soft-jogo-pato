using JogoPatosCSharp.Model;

PatoRuivoModel patoRuivo = new();

Console.WriteLine(patoRuivo.Mostrar());
Console.WriteLine(patoRuivo.Nadar());
Console.WriteLine(patoRuivo.Comportamento());

patoRuivo.SetComportamento(new VoarFogueteModel());

Console.WriteLine(patoRuivo.Comportamento());
Console.ReadKey();