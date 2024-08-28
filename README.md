Random aleatorio = new Random();
int numeroSecreto = aleatorio.Next(1,101);
do{
    Console.Write("Digite um número entra 1 e 100: ");
    int chute = int.Parse(Console.ReadLine());

    if(chute == numeroSecreto){
        Console.WriteLine("Parebéns! Você acertou o número.");
        break;
    }else if(chute < numeroSecreto){
        Console.WriteLine("O número é maior, chuta alto ai.");

    }else{
    Console.WriteLine("O número é menor, que isso vai catar manga?");    
    }

}while(true);
Console.WriteLine("O jogo acabou. Você acertou o número secreto!");
