using System;

namespace HypermarketCourseWork_A_;

public class Buyer
{
    private decimal money;

    // Номер звичайного покупця
    public int Number { get; set; }

    // Кількість грошей покупця
    public decimal Money
    {
        get => money;
        set
        {
            if (value < 0)
                throw new ArgumentException("Гроші не можуть бути від'ємними.");

            money = value;
        }
    }

    public Buyer(decimal money)
    {
        Money = money;
    }

    // Індивідуальна знижка покупця
    public virtual double IndividualDiscount()
    {
        return 0;
    }

    // Купівля товару
    public virtual decimal BuyProduct(Product product)
    {
        if (product == null)
            throw new ArgumentException("Товар не вибрано.");

        double discount = IndividualDiscount();

        // Знижка не може бути більшою за максимальну знижку товару
        if (discount > product.MaxDiscountPercent)
            discount = product.MaxDiscountPercent;

        decimal finalPrice = product.Price - product.Price * (decimal)discount / 100;

        // Перевірка наявності грошей
        if (Money < finalPrice)
            throw new InvalidOperationException("Недостатньо грошей для покупки.");

        Money -= finalPrice;

        return finalPrice;
    }

    public override string ToString()
    {
        return $"Покупець №{Number} | гроші: {Money} грн";
    }
}