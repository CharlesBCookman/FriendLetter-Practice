using FriendLetter.Models;
using Microsoft.AspNetCore.Mvc;

namespace FriendLetter.Controllers
{
  public class HomeController : Controller
  {

    [Route("/hello")]
    public string Hello() { return "Hello friend!"; }

    [Route("/goodbye")]
    public string Goodbye() { return "Goodbye friend."; }
    [Route("/")]
    public ActionResult Letter()
    {
      LetterVariable myLetterVariable = new LetterVariable();
      myLetterVariable.Recipient = "Lina";
      myLetterVariable.Sender = "Jasmine";
      return View(myLetterVariable);
    }

    [Route("/postcard")]
    public ActionResult Postcard(string recipient, string sender)
    {
    LetterVariable myLetterVariable = new LetterVariable();
    myLetterVariable.Recipient = recipient;
    myLetterVariable.Sender = sender;
    return View(myLetterVariable);
    }


  }
}