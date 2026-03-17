Console.Clear();

//1 - Criar um vetor de valores inteiros com N posições
int[] vetor = new int[100];

//2 - Criar um objeto Random
Random random = new Random();

//3 - Criar um laço de repetição para percorrer o vetor
for (int i = 0; i < vetor.Length; i++)
{
    //4 - Atribuir um valor aleatório para cada posição
    vetor[i] = random.Next(1000);
}

//5 - Imprimir o vetor sem ordenação
Console.WriteLine("Vetor sem ordenação:");
for (int i = 0; i < vetor.Length; i++)
{
    Console.Write(vetor[i] + " ");
}

//6 - Ordenar o vetor
Array.Sort(vetor);

//7 - Imprimir o vetor com ordenação
Console.WriteLine("\n\nVetor ordenado:");
for (int i = 0; i < vetor.Length; i++)
{
    Console.Write(vetor[i] + " ");
}