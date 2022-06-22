using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Mvc;
using Trabajo.Practico.Entiti.Framework.MVC.Models;

namespace Trabajo.Practico.Entiti.Framework.MVC.Controllers
{
    public class ApiJSonController : Controller
    {
        // GET: ApiJSon
        public ActionResult Index()
        {
            var list = GetApiModelList();
            var arrayModel=list.Result.ToArray();
            
            return View(arrayModel);
        }
       public async Task<List<ApiModel>> GetApiModelList()
        {
            HttpClient client = new HttpClient();
            Uri uri = new Uri("https://jsonplaceholder.typicode.com/posts");
            HttpResponseMessage message = await client.GetAsync(uri);
            List<ApiModel> list=null;
            if (message.IsSuccessStatusCode)
            {
                var content = await message.Content.ReadAsStringAsync();
                list =Newtonsoft.Json.JsonConvert.DeserializeObject<List<ApiModel>>(content);
            }

            return list;
        }
    }

}