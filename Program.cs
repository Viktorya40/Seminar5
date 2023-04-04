Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] randomArray = new int[n];

void array (int n)
{
for (int i = 0; i < n; i++)
{
randomArray[i] = new Random().Next(99,999);
Console.Write(randomArray[i] + " ");
}

}

int count(int[] randomArray)
{
int count = 0;
for (int i = 0; i < randomArray.Length; i++)
{
if (randomArray[i] % 2 == 0)
count = count + 1;
}
return count;
}
array(n);
Console.Write($"Количество чётных чисел в массиве: {count(randomArray)}");