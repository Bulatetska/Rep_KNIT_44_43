using Microsoft.AspNetCore.Mvc.Filters;
using System.Diagnostics;

namespace ECommerceApp.Filters
{
    public class CustomActionFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            // Логіка перед виконанням дії
            Debug.WriteLine("Action is executing");
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            // Логіка після виконання дії
            Debug.WriteLine("Action executed");
        }
    }
}
