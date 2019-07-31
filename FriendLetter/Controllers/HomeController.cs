using Microsoft.AspNetCore.Mvc;
using FriendLetter.Models;

namespace FriendLetter.Controllers
{
  public class HomeController : Controller
  {
    [Route("/hello")]
    public string Hello() { return "Hello friend!"; }

    [Route("/goodbye")]
    public string Goodbye() { return "Goodbye friend."; }

    // [Route("/")]
    // public string Letter() { return "Our virtual postcard will go here soon!"; }


    [Route("/")]
    public ActionResult Letter()
    {
      LetterVariable myLetterVariable = new LetterVariable();
      myLetterVariable.Recipient = "Lina";
      myLetterVariable.Sender = "Jasmine";
      return View(myLetterVariable);
    }
    [Route("/form")]
    public ActionResult Form()
    {
      return View();
    }

    [Route("/postcard")]
    public ActionResult Postcard(string recipient, string sender, string location1, string verb1)
    {
      LetterVariable myLetterVariable = new LetterVariable();
      myLetterVariable.Recipient = recipient;
      myLetterVariable.Sender = sender;
      myLetterVariable.Location1 = location1;
      myLetterVariable.Verb1 = verb1;

      return View(myLetterVariable);
    }

    [Route("/favorite_photos")]
    public ActionResult FavoritePhotos()
    {
      return View();
    }
  }
}
