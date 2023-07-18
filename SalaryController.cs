using Microsoft.AspNetCore.Mvc;
using InjectionDependances.Services;


namespace InjectionDependances.Controllers
{
    [Route("api/[controller]")]
    public class SalaryController : Controller
    {



        private ISalaryCalculator _calculator;

        public SalaryController(ISalaryCalculator injectedCalculator)
        {
            _calculator = injectedCalculator;
        }

      /*  [HttpGet("/yearlyAmount")]
        public Double Get(Double yearlyAmount)
        {
            Double calculatedSalary = _calculator.CalculateSalary(yearlyAmount);
            return calculatedSalary;
        } */



        [HttpGet("/quarterlySalary")]
        public Double Get1(Double quarterlySalary)
        {
            Double calculatedSalary = _calculator.CalculateSalary1(quarterlySalary);
            return quarterlySalary;
        }




        


        public IActionResult Index()
        {
            return View();
        }
    }
}
