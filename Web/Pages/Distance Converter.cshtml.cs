using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ConsoleAppProject.App01;
namespace Web.Pages
{
    public class Distance_ConverterModel : PageModel
    {
        [BindProperty]
        public DistanceConverter App01 { get; set; }
        public void OnGet()
        {

        }
        public void OnPost()
        {
            App01.Calculate();
            ViewData["Message"] = App01.fromDistance + "" + App01.fromUnit.ToString() +
                " is " + App01.toDistance + " " + App01.toUnit.ToString();

        }
    }
}

