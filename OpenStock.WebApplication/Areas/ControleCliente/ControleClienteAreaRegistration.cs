using System.Web.Mvc;

namespace WebApplication.Areas.ControleCliente
{
    public class ControleClienteAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "ControleCliente";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "ControleCliente_default",
                "ControleCliente/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}