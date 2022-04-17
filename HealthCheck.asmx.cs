using SoapTrainingAssure.Models;
using System.Web.Services;

namespace SoapTrainingAssure
{
    /// <summary>
    /// Descripción breve de HelloWorld
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class HealthCheck : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }

        [WebMethod]
        public ResponseModel<string> Login(string email, string password)
        {
            ResponseModel<string> response = new ResponseModel<string>();

            if (!string.IsNullOrEmpty(email))
            {
                response.Data = "ok";
                response.resultCode = 200;
            }
            else
            {
                response.message = "User Not Found!";
                response.resultCode = 404;
            }

            return response;
        }
    }
}
