using PresidentVote.Entities;

Candidates candidate = new("Lula");
Candidates candidate2 = new("Bolsonaro");
Candidates candidate3 = new("Ciro");

int votes = 0;

Console.WriteLine("Votação para presidente!");
Console.WriteLine("**************************");
Console.WriteLine("Quantos eleitores irão votar?");
Console.Write("Quantidade de eleitores: ");
int howManyVoters = int.Parse(Console.ReadLine());

for (int i = 0; i < howManyVoters; i++) {
   
    Console.WriteLine("\nInforme o número do candidato!");
    Console.WriteLine("Lula - 13");
    Console.WriteLine("Bolsonaro - 17");
    Console.WriteLine("Ciro - 42\n");
    Console.Write("sua escolha: ");

    int voterChoise = int.Parse(Console.ReadLine());

    switch (voterChoise) {
        case 13:
            candidate.NumberOfVotes += votes + 1;
            break;
        case 17:
            candidate2.NumberOfVotes += votes + 1;
            break;
        case 42:
            candidate3.NumberOfVotes += votes + 1;
            break;
        default:
            Console.WriteLine("\nNúmero inválido");
            break;
    }
}

    Console.WriteLine("\nResultado:");

Candidates[] candidates = { candidate, candidate2, candidate3 };
var winner = candidates.MaxBy(x => x.NumberOfVotes);

foreach (var item in candidates) {
    Console.WriteLine(item);
}

Console.WriteLine("\nVencedor: ");
Console.WriteLine(winner);









