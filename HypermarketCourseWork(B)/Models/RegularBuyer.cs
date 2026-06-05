using System;

namespace HypermarketCourseWork_A_;

public class RegularBuyer : Buyer
{
    private string fullName;
    private decimal totalBoughtSum;

    // ПІБ постійного покупця
    public string FullName
    {
        get => fullName;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("ПІБ не може бути порожнім.");

            fullName = value;
        }
    }

    // Загальна сума куплених товарів
    public decimal TotalBoughtSum
    {
        get => totalBoughtSum;
        set
        {
            if (value < 0)
                throw new ArgumentException("Сума покупок не може бути від'ємною.");

            totalBoughtSum = value;
        }
    }

    public RegularBuyer(string fullName, decimal money, decimal totalBoughtSum)
        : base(money)
    {
        FullName = fullName;
        TotalBoughtSum = totalBoughtSum;
    }

    // Знижка постійного покупця
    public override double IndividualDiscount()
    {
        double discount = (double)(TotalBoughtSum / 1000);

        if (discount > 15)
            discount = 15;

        return discount;
    }

    // Після покупки збільшується загальна сума покупок
    public override decimal BuyProduct(Product product)
    {
        decimal finalPrice = base.BuyProduct(product);

        TotalBoughtSum += finalPrice;

        return finalPrice;
    }

    public override string ToString()
    {
        return $"Постійний покупець: {FullName} | гроші: {Money} грн | куплено: {TotalBoughtSum} грн | знижка: {IndividualDiscount()}%";
    }
}