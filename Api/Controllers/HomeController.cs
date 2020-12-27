
using System;
using System.Web.Mvc;
using Api.Utils;

namespace Api.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            String mensagem = "O importante não é vencer todos os dias, mas lutar sempre.";
            String cripto = EncryptCustom.Encrypt(mensagem,true);
            String descrit = EncryptCustom.Decrypt(cripto,true);
            ViewBag.mensagem = mensagem;
            ViewBag.cripto = cripto;
            ViewBag.descrit = descrit;
            ViewBag.mensagembase64 = System.Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(mensagem));
            return View();
        }

        
        [Authorize]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }
        
        
        
       
    }
}