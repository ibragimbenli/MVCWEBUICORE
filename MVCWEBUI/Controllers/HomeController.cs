using Microsoft.AspNetCore.Mvc;
using MVCWEBUI.Models;
using System.Text.Json;

namespace MVCWEBUI.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:5027/api");
            var response = await client.GetAsync($"{client.BaseAddress}/Category");
            var responseRead = await response.Content.ReadAsStringAsync();
            var resultCt = JsonSerializer.Deserialize<ResponseComing<CategoryItem>>(responseRead);

            var responsePr = await client.GetAsync($"{client.BaseAddress}/Products");
            var responseReadPr = await responsePr.Content.ReadAsStringAsync();
            var resultPr = JsonSerializer.Deserialize<ResponseComing<ProductItem>>(responseReadPr);

            var categorylist = resultCt.data;
            var productList = resultPr.data;

            HomeIndexViewModel viewModel = new HomeIndexViewModel();
            viewModel.ProductList = productList;
            viewModel.CategoryList = categorylist;
            return View(viewModel);
        }

    }
}
