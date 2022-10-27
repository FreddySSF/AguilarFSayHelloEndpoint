// Fernando Aguilar
// 10-25-22
// Say Hello Endpoint
// We are taking our first mini challenge from the combine and converting to API format.
// The user the puts their input into the url, outputting the result on Postman.
// Peer Reviewed By: Pedro Castaneda - Freddy did a great job setting up the api. His variable inside of the Route() is set up properly and when I make my input in the URL I get the correct response. Great work.

using Microsoft.AspNetCore.Mvc;

namespace AguilarFSayHelloEndpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class SayHelloController : ControllerBase
{
   [HttpGet]
   [Route("Hello/{name}")]

   public string sayHello(string name)
   {
    return $" Good morning {name}!";
   }
}
