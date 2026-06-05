using System;
using System.Collections.Generic;

namespace HypermarketCourseWork_A_;

public class Smartphone : MobilePhone
{
    private string operatingSystem;
    private List<string> installedPrograms;

    // Операційна система смартфона
    public string OperatingSystem
    {
        get => operatingSystem;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("ОС не може бути порожньою.");

            operatingSystem = value;
        }
    }

    // Список встановлених програм
    public List<string> InstalledPrograms
    {
        get => installedPrograms;
        set
        {
            if (value == null)
                throw new ArgumentException("Список програм не може бути null.");

            installedPrograms = value;
        }
    }

    public Smartphone(
        string firm,
        string name,
        decimal price,
        double maxDiscountPercent,
        bool hasContract,
        int maxSimCards,
        string operatingSystem,
        List<string> installedPrograms)
        : base(firm, name, price, maxDiscountPercent, hasContract, maxSimCards)
    {
        OperatingSystem = operatingSystem;
        InstalledPrograms = installedPrograms;
    }

    public override string ToString()
    {
        string programs = InstalledPrograms.Count == 0
            ? "немає"
            : string.Join(", ", InstalledPrograms);

        return $"Смартфон: {base.ToString()} | ОС: {OperatingSystem} | програми: {programs}";
    }
}