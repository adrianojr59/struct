using vetores;

dados x;

int linha = 0;
int coluna= 0;

char option;

x.X = new int[11,6]; // 10 linha horizontal    5 colunas vertical   total 50
// _ = valor 



//criar linha 

do
{   Console.WriteLine($"Linha Limite 10  preenchido {linha} de 10 "); 
    Console.WriteLine("Digite ");
    x.X[linha, 0] = int.Parse(Console.ReadLine());
    linha++;

    Console.Write("Deseja Sair ? (S/N)");
    option = char.Parse(Console.ReadLine());

    
}
while (option == 'n' || option == 'N'  && linha <=10   );

//criar coluna
do
{
    Console.WriteLine($"Coluna Limite 5  preenchido {coluna} de 5 ");
    Console.WriteLine("Digite ");
    x.X[0,coluna] = int.Parse(Console.ReadLine());
    coluna++;

    Console.Write("Deseja Sair ? (S/N)");
    option = char.Parse(Console.ReadLine());


}
while (option == 'n' || option == 'N' && coluna <= 5);






// varrer vetores  linha 0
for (int i = 0; i<linha; i++) {
    
Console.WriteLine($"posição vetor {i}   Linha  contem o Valor: "+x.X[i,0]);

}



// varrer vetores   coluna 0   que esta na linha 0
for (int i = 1; i < coluna; i++)
{

    Console.WriteLine($"posição Coluna vetor {i}   Coluna 0 contem o Valor: " + x.X[0,i]);

}



Console.WriteLine("Procurar valor em vetor linha  ja digitado ");
 int procurar =  int.Parse(Console.ReadLine());
 
for (int i = 0; i < linha; i++)
{

     if( procurar == x.X[i, 0])
    {

        Console.WriteLine("encontrado: "+ x.X[i, 0]);

        Console.WriteLine("Digite um novo valor ");
        x.X[i, 0] =  int.Parse(Console.ReadLine());

    }

    

}


Console.WriteLine("Procurar valor em vetor coluna  ja digitado ");
int procurar2 = int.Parse(Console.ReadLine());

for (int i = 1; i < coluna; i++)
{

    if (procurar2 == x.X[0, i])
    {

        Console.WriteLine("encontrado: " + x.X[0,i]);

        Console.WriteLine("Digite um novo valor ");
        x.X[0,i] = int.Parse(Console.ReadLine());

    }

}





Console.WriteLine("Procurar valor em vetor linha  ja digitado para apagar ");
int procurar3 = int.Parse(Console.ReadLine());

for (int i = 0; i < linha; i++)
{

    if (procurar3 == x.X[i, 0])
    {

        Console.WriteLine("encontrado: " + x.X[i, 0]);

        Console.WriteLine("Digite um novo valor ");
        x.X[i, 0] = 0;

    }



}






Console.WriteLine("Procurar valor em vetor Coluna  ja digitado para apagar ");
int apagar = int.Parse(Console.ReadLine());

for (int i = 1; i < coluna; i++)
{

    if (apagar == x.X[0,i])
    {

        Console.WriteLine("encontrado: " + x.X[0,i]);

        x.X[0,i] = 0;

    }



}






// varrer vetores  linha 0 coluna 0
for (int i = 0; i < linha; i++)
{
    Console.WriteLine($"posição linha vetor {i}   linha 0 contem o Valor: " + x.X[i, 0]);
}


// varrer vetores  coluna
for (int i = 1; i < coluna; i++)
{
    Console.WriteLine($"posição vetor {i}   Coluna  contem o Valor: " + x.X[0,i]);
}






