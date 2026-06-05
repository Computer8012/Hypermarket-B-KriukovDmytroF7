using System;

namespace HypermarketCourseWork_A_;

public class Laptop : Product
{
    private double diagonal;
    private double weight;
    private int processorCores;
    private int memory;

    // Діагональ екрана
    public double Diagonal
    {
        get => diagonal;
        set
        {
            if (value <= 0)
                throw new ArgumentException("Діагональ повинна бути більшою за 0.");

            diagonal = value;
        }
    }

    // Вага ноутбука
    public double Weight
    {
        get => weight;
        set
        {
            if (value <= 0)
                throw new ArgumentException("Вага повинна бути більшою за 0.");

            weight = value;
        }
    }

    // Кількість ядер процесора
    public int ProcessorCores
    {
        get => processorCores;
        set
        {
            if (value <= 0)
                throw new ArgumentException("Кількість ядер повинна бути більшою за 0.");

            processorCores = value;
        }
    }

    // Обсяг пам'яті
    public int Memory
    {
        get => memory;
        set
        {
            if (value <= 0)
                throw new ArgumentException("Пам'ять повинна бути більшою за 0.");

            memory = value;
        }
    }

    public Laptop(
        string firm,
        string name,
        decimal price,
        double maxDiscountPercent,
        double diagonal,
        double weight,
        int processorCores,
        int memory)
        : base(firm, name, price, maxDiscountPercent)
    {
        Diagonal = diagonal;
        Weight = weight;
        ProcessorCores = processorCores;
        Memory = memory;
    }

    public override string ToString()
    {
        return $"Ноутбук: {base.ToString()} | {Diagonal}\" | {Weight} кг | ядер: {ProcessorCores} | пам'ять: {Memory} ГБ";
    }
}