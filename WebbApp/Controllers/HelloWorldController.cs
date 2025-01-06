using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace WebbApp.Controllers;

//localhost/helloworld
public class HelloWorldController : Controller
{
    // 
    // GET: /HelloWorld/
    public IActionResult Index()
    {
        return View();
    }
    // 
    // GET: /HelloWorld/Welcome/  
    // Requires using System.Text.Encodings.Web;
    //ex: https://localhost:7021/HelloWorld/Welcome?name=Rick&numtimes=4
    public IActionResult Welcome(string name, int numTimes)
    {
        ViewData["Message"] = "Hello " + name;
        ViewData["Numtimes"] = numTimes;
        return View();
    }
}