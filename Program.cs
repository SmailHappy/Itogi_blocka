System.Console.WriteLine("Из N элементов массива A формируется новый массив размер элементов которого меньше либо равна 3");
System.Console.Write("Введите количество N: ");
int num = Convert.ToInt32(Console.ReadLine());

string[] array = new string[num];
for (int i = 0; i < num; i++) {
    System.Console.Write($"Введите {i + 1} элемент массива A: ");
    array[i] = Console.ReadLine();
}
