namespace InjectionDependances.Services
{
    public class QuarterlySalaryCalculator : ISalaryCalculator
    {
        public double CalculateSalary1(double annualSalary)
        {
            double quarterlySalary = annualSalary / 4;
            return quarterlySalary;
        }

    }
}
