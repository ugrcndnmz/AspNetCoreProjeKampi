using CoreDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents
{
    public class CommentList: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commentvalues = new List<UserComment>
            {
                new UserComment
                {
                    ID = 1,
                    Username = "Uğurcan"
                },
                new UserComment
                {
                    ID = 2,
                    Username = "Mesut"
                },
                new UserComment
                {
                    ID = 3,
                    Username = "Buğra"
                }
            };
            return View(commentvalues);
        }
    }
}
