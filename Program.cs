Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

void cub(int[] N)
{
    int length = N.Length;  
    for (int i = 0; i < length; i++)
    {
        N[i] = Convert.ToInt32(Math.Pow(i, 3));
    }
}

void Print(int[] cuub)
{
    int length1 = cuub.Length;
    for (int index = 0; index < length1; index++)
    {
        Console.Write(cuub[index]+ " ");
    }
} 

int[] array = new int[N + 1];
cub(array);
Print(array);