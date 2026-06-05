using System;

namespace HypermarketCourseWork_A_;

public class Product
{
    private string firm;
    private string name;
    private decimal price;
    private double maxDiscountPercent;

    // Фірма товару
    public string Firm
    {
        get => firm;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Фірма не може бути порожньою.");

            firm = value;
        }
    }

    // Назва товару
    public string Name
    {
        get => name;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Назва не може бути порожньою.");

            name = value;
        }
    }

    // Ціна товару
    public decimal Price
    {
        get => price;
        set
        {
            if (value <= 0)
                throw new ArgumentException("Ціна повинна бути більшою за 0.");

            price = value;
        }
    }

    // Максимальна знижка на товар
    public double MaxDiscountPercent
    {
        get => maxDiscountPercent;
        set
        {
            if (value < 0 || value > 100)
                throw new ArgumentException("Знижка повинна бути від 0 до 100%.");

            maxDiscountPercent = value;
        }
    }

    public Product(string firm, string name, decimal price, double maxDiscountPercent)
    {
        Firm = firm;
        Name = name;
        Price = price;
        MaxDiscountPercent = maxDiscountPercent;
    }

    public override string ToString()
    {
        return $"{Firm} {Name} | {Price} грн | макс. знижка {MaxDiscountPercent}%";
    }
}