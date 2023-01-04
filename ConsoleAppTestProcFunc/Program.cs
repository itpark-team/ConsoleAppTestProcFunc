int InputNumber(string msg, int minValue, int maxValue)
{
    bool isCorrectInput;
    int number = 0;
    do
    {
        isCorrectInput = true;

        try
        {
            Console.Write(msg);
            number = int.Parse(Console.ReadLine());

            if (number < minValue || number > maxValue)
            {
                Console.WriteLine($"Ошибка. Число должно быть от {minValue} до {maxValue}");
                isCorrectInput = false;
            }
        }
        catch
        {
            Console.WriteLine("Ошибка. Введите число");
            isCorrectInput = false;
        }
    } while (!isCorrectInput);

    return number;
}

int Sum(int a, int b)
{
    return a + b;
}

void PrintSum(int sum)
{
    Console.WriteLine($"сумма = {sum}");
}

//--------

int a = InputNumber("введи a (от 1 до 100): ", 1, 100);
int b = InputNumber("введи b (от 1 до 100): ", 1, 100);

int sum = Sum(a, b);

PrintSum(sum);