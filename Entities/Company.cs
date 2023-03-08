namespace Exercicio_POO_17_Classes_Metodos_Abstratos_Contribuintes.Entities
{
    public class Company : TaxPayer
    {
        public int NumberEmployees { get; set; }

        public Company(string name, double anualIncome, int numberEmployees) : base(name, anualIncome)
        {
            NumberEmployees = numberEmployees;
        }

        public override double Tax()
        {
            if (NumberEmployees > 10)
                return AnualIncome * 0.14;
            else
                return AnualIncome * 0.16;
        }
    }
}
