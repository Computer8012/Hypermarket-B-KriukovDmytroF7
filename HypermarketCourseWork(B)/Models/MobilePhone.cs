using System;

namespace HypermarketCourseWork_A_;

public class MobilePhone : Product
{
    private int maxSimCards;

    // Чи продається телефон з контрактом
    public bool HasContract { get; set; }

    // Максимальна кількість SIM-карт
    public int MaxSimCards
    {
        get => maxSimCards;
        set
        {
            if (value <= 0)
                throw new ArgumentException("Кількість SIM-карт повинна бути більшою за 0.");

            maxSimCards = value;
        }
    }

    public MobilePhone(
        string firm,
        string name,
        decimal price,
        double maxDiscountPercent,
        bool hasContract,
        int maxSimCards)
        : base(firm, name, price, maxDiscountPercent)
    {
        HasContract = hasContract;
        MaxSimCards = maxSimCards;
    }

    public override string ToString()
    {
        string contract = HasContract ? "з контрактом" : "без контракту";

        return $"Мобільний телефон: {base.ToString()} | {contract} | SIM: {MaxSimCards}";
    }
}