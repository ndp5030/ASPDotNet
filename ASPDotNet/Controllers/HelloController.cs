using Microsoft.AspNetCore.Mvc;

namespace ASPDotNet.Controllers
{
    public class HelloController : Controller
    {
        [HttpGet]
        // GET: /<controller>/
        public IActionResult Index()
        {
            string html = "<h1>Skill Tracker</h1>" +
                "<h2>Coding Skills to Learn</h2>" +
                "<ol>" +
                "<li>C#</li>" +
                "<li>JavaScript</li>" +
                "<li>Python</li>" +
                "</ol>";
            return Content(html, "text/html");
        }

        [Route("/skills/form")]
        public IActionResult SkillForm()
        {
            string html = "<form method='post'>" +
                "<label for='date'> Date:</label>" +
                "<br>" +
                "<input type='date'>" +
                "<br>" +
                "<label for='C#'> C#</label>" +
                "<br>" +
                "<select name = 'C#'>" +
                "option value='beginner' selected>Beginner</option>" +
                "option value='intermediate' selected>Intermediate</option>" +
                "option value='advanced' selected>Advanced</option>" +
                "</select>" +
                "<br>" +
                "<label for='JavaScript'> JavaScript</label>" +
                "<br>" +
                "<select name = 'JavaScript'>" +
                "option value='beginner' selected>Beginner</option>" +
                "option value='intermediate' selected>Intermediate</option>" +
                "option value='advanced' selected>Advanced</option>" +
                "</select>" +
                "<br>" +
                "<label for='Python'> Python</label>" +
                "<br>" +
                "<select name = 'Python'>" +
                "option value='beginner' selected>Beginner</option>" +
                "option value='intermediate' selected>Intermediate</option>" +
                "option value='advanced' selected>Advanced</option>" +
                "</select>" +
                "<br>" +
                "<input type='submit' value='Submit' />" +
                "</form>";
            return Content(html, "text/html");
        }
    }
}
