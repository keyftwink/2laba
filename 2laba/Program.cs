class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Введите размерность массива: ");
        int lenght = Convert.ToInt32(Console.ReadLine());

        Random random = new Random();
        int[] array = new int[lenght];

        Console.WriteLine("Сгенерированный массив: ");
        for(int i = 0; i < lenght; i++)
        {
            array[i] = random.Next(-20, 20);
            Console.Write(array[i] + ", ");
        }

        for(int i = 1; i < lenght; i++)
        {
            int k = array[i];
            int j = i - 1;

            while (j >= 0 && k < array[j])
            {
                array[j + 1] = array[j];
                j--;
            }
            array[j + 1] = k;
        }

        Console.WriteLine("\nОтсортированный массив: ");
        for (int i = 0; i < lenght; i++)
        {
            Console.Write(array[i] + ", ");
        }
    }
}


        