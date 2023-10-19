namespace ConsoleApp24
{

    delegate int NumberOperation(int number);

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите трехзначное число:");
            int inputNumber = int.Parse(Console.ReadLine());

            // Создание делегата с требуемой сигнатурой с использованием блочного лямбда-выражения
            NumberOperation operation = (number) =>
            {
                int firstDigit = number / 100; // Получение первой слева цифры
                int newNumber = (number % 100) * 10 + firstDigit; // Приписываем первую цифру справа
                return newNumber;
            };

            // Вызов делегата для выполнения основного алгоритма задачи
            int result = operation(inputNumber);

            Console.WriteLine("Результат: " + result);
            Console.ReadLine();
        }
    }

}