using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TriangleApplication.Controllers
{
  [Route("api/[controller]")]
  public class ValuesController : Controller
  {
    // GET api/values
    [HttpGet]
    public string Get(int first, int second, int third)
    {
      var numbers = new List<int> {first, second, third}.OrderByDescending(n => n).ToList();
      if ((numbers[1] + numbers[2]) < numbers[0])
      {
        return "not a triangle";
      }

      if (numbers[0] == numbers[1] && (numbers[1] == numbers[2]) && (numbers[0] == numbers[2]))
      {
        return "equilateral";
      }

      if (numbers[0] == numbers[1] && (numbers[1] != numbers[2]) ||
        (numbers[1] == numbers[2] && (numbers[1] != numbers[0])) ||
          (numbers[0] == numbers[2] && (numbers[0] != numbers[1])))
      {
        return "isoceles";
      }

      if (numbers[0] != numbers[1] && numbers[0] != numbers[2] && numbers[1] != numbers[2])
      {
        return "scalene";
      }

      return "invalid data";
    }

  }
}
