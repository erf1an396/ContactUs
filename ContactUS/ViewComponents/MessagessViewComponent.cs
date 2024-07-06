using Microsoft.AspNetCore.Mvc;

namespace ContactUs.ViewComponents
{
    public class MessagessViewComponent :ViewComponent
    {

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return await Task.FromResult(View("TableMessage", DataBase.DataBase.Messages));
        }
    }
}
