using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {

        Console.Write("Введите колличество элементов в массиве:");

        int elementsCount= int.Parse(Console.ReadLine());

        int[] MyArray = new int[elementsCount];



        for (int k = 0; k < MyArray.Length; k++  )
        {
            Console.WriteLine($"Введите элемент масива под индексом {k}:\t"); 
            MyArray[k] = int.Parse(Console.ReadLine());
        }


        Console.WriteLine("Вывод массива");

        for (int i = 0; i < MyArray.Length; i++) 
        {
            Console.WriteLine(MyArray[i]);
        } 
        Console.ReadLine();
    }
}