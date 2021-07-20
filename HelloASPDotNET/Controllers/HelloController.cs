using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloASPDotNET.Controllers
{
    [Route("/helloworld/")]
    public class HelloController : Controller
    {

        //GET: /<controller>/
        [HttpGet]
        
        /*public IActionResult Index()
        {
            string html = "<form method='post' action='/helloworld/'>" + 
                "<input type='text' name='name' />" + 
                "<input type='submit' value='Greet Me!' />" +
                "</form>";
            return Content(html, "text/html");
        }*/


        [HttpGet]
        public IActionResult Index()
        {
            string html = "<form method='post' action='/helloworld/'>" +
                "<input type='text' name='name' />" +
                "<select name='language'><option value='1' selected>English</option><option value='2'>French</option>" +
                "<option value='3'>Spanish</option><option value='4'>Haitian-Dialect</option><option value='5'>Polish</option></select>" +
                "<input type='submit' value='Greet Me!' />" +
                "</form>";                

            return Content(html, "text/html");
        }

        [HttpPost]
        public IActionResult Name(int language, string name = "World")
        {
            if(language == 1)
            {
                return Content("<h1>Welcome to my app, " + name + "!</h1>", "text/html");
            }
            else if (language == 2)
            {
                return Content("<h1>Bonjour, " + name + "!</h1>", "text/html");
            }
            else if (language == 3)
            {
                return Content("<h1>¡Hola, " + name + "!</h1>", "text/html");
            }
            else if (language == 4)
            {
                return Content("<h1>Sak-Pase, " + name + "!</h1>", "text/html");
            }
            else
            {
                return Content("<h1>Witamy, " + name + "!</h1>", "text/html");
            }
        }


        //GET: 
       /* [HttpGet("/welcome/{name?}"]
        [HttpPost]
        
        public IActionResult Welcome(string name = "World")
        {
            return Content("<h1>Welcome to my app, " + name + "!</h1>" , "text/html");
        }*/
        
    }
}
