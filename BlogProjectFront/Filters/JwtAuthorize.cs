using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using BlogProjectFront.Extensions;
using BlogProjectFront.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;

namespace BlogProjectFront.Filters
{
    public class JwtAuthorize : ActionFilterAttribute
    {
        public override void OnResultExecuting(ResultExecutingContext context)
        {
            var token = context.HttpContext.Session.GetString("token");
            if (string.IsNullOrWhiteSpace(token))
            {
                context.Result = new RedirectToActionResult("SignIn", "Account", new {@area=""});
            }
            else
            {
                using var httpClient = new HttpClient();
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                var responseMessage = httpClient.GetAsync("http://localhost:52947/api/Auth/ActiveUser").Result;

                if (responseMessage.IsSuccessStatusCode)
                {
                    var activeUser = JsonConvert.DeserializeObject<AppUserViewModel>(responseMessage.Content.ReadAsStringAsync().Result);
                    
                    context.HttpContext.Session.SetObject("activeUser",activeUser);
                }
                else
                {
                    context.Result = new RedirectToActionResult("SignIn", "Account", new {@area=""});
                }
            }
        }
    }
}