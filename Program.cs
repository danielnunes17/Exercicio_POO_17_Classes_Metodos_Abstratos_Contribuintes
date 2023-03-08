using Exercicio_POO_17_Classes_Metodos_Abstratos_Contribuintes.Entities;
using System.Globalization;

public class Program
{
    public static void Main(string[] args)
    {
        List<TaxPayer> taxPayers = new List<TaxPayer>();

        Console.Write("Enter the number of tax payers: ");
        int taxNumber = int.Parse(Console.ReadLine());
        for (int i = 1; i <= taxNumber; i++)
        {
            Console.WriteLine($"Tax payer #{i} data:");
            Console.Write("Individual or company (i/c)? ");
            char companyType = char.Parse(Console.ReadLine());
            if (companyType == 'i')
                taxPayers.Add(CreateTaxPayerIndividual());
            else
                taxPayers.Add(CreateTaxPayerCompany());
        }
        double sum = 0.0;
        Console.WriteLine();
        Console.WriteLine("TAXES PAID:");
        foreach (TaxPayer taxPayer in taxPayers)
        {
            double taxSum = taxPayer.Tax();
            Console.WriteLine(taxPayer.Name + ": $ " + taxSum.ToString("F2", CultureInfo.InvariantCulture));
            sum += taxSum;
        }

        Console.WriteLine();
        Console.WriteLine("TOTAL TAXES: $" + sum.ToString("F2", CultureInfo.InvariantCulture));
    }
    private static Individual CreateTaxPayerIndividual()
    {
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Anual income: ");
        double anualincome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Health expenditures: ");
        double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        return new Individual(name, anualincome, healthExpenditures);
    }

    private static Company CreateTaxPayerCompany()
    {
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Anual income: ");
        double anualincome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Number of employees: ");
        int numberEmployees = int.Parse(Console.ReadLine());
        return new Company(name, anualincome, numberEmployees);
    }
}