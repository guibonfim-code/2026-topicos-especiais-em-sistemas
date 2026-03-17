Console.Clear();
//Passo a passo para criar uma solução e projeto e C#

//1 - Criar a solução           dotnet new sln --output Nome
//2 - Entrar na pasta sln       cd nome da pasta
//3 - Criar o projeto           dotnet new console --name Nome
//4 - Adicionar o projetona sln dotnet sln add NomeProjeto

//Passo a passo para resolver o exercício 06

//1 - Criar um vetor de valores inteiros com N posições
int[] vetor = new int[100];

//2 - Criar um laço de repetição para percorrer o vetor
for (int i = 0; i < vetor.Length; i++)
{
//3 - Atribuir um valor aleatório para cada posição
    Random random = new Random();
    vetor[i] = random.Next(1000);
}

//4 - Imprimir o vetor sem ordenção
for (int i = 1; i < vetor.Length; i++)
{
    Console.Write(vetor[i] + " ");
}

//5 - Criar um laço de repetição para comparar o valor atual com o próximo
bool troca = false;
do 
{
    troca = false;
    for (int i = 0; i < vetor.Length - 1; i++)
    {   
        if (vetor[i] > vetor[i + 1])
        {
            troca = true;
            int aux = vetor[i];
            vetor[i] = vetor[i + 1];
            vetor[i + 1] = aux;
        }
    }
} while (troca == true);

Console.WriteLine("\n");

//7 - Imprimir o vetor com ordenação
for (int i = 1; i < vetor.Length; i++)
{
    Console.Write(vetor[i] + " ");
}