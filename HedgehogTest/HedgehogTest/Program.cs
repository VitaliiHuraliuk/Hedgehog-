class MainClass
{
    public static int ChangeColor(int[] population, int desiredColor)
    {
        // Перевірка, чи всі їжачки вже мають бажаний колір
        if (population[desiredColor] == population[0] + population[1] + population[2])
            return 0;

        if (population[desiredColor] == 0)
            return -1;

        return (Math.Max(population[0], Math.Max(population[1], population[2])) - population[desiredColor] + 1) / 2;
    }

    public static void Main(string[] args)
    {
        int[] population = new int[] { 8, 1, 9 };
        int desiredColor = 1; // Бажаний колір: зелений

        int result = ChangeColor(population, desiredColor);
        Console.WriteLine("Мінімальна кількість зустрічей, необхідних для зміни всіх їжачків у зелений колір: " + result);
    }
}
