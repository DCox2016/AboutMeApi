using Microsoft.AspNetCore.Mvc;

namespace AboutMeAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AboutMeController : ControllerBase
    {

        [HttpGet(Name = "GetAboutMe")]
        public IEnumerable<AboutMe> Get()
        {
            return Enumerable.Range(1, 1).Select(index => new AboutMe
            {
                Name = "Dustin Cox",
                Age = 39,
                Location = "Gainesville",
                Bio = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                Experience = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.",
                Skills = "At vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis praesentium voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident, similique sunt in culpa qui officia deserunt mollitia animi, id est laborum et dolorum fuga. Et harum quidem rerum facilis est et expedita distinctio."
            })
            .ToArray();
        }
    }
}
