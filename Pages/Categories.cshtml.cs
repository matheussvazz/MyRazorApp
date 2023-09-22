using Microsoft.AspNetCore.Mvc.RazorPages;


namespace MyRazorApp.Pages
{
    public class Categories : PageModel
    {
        public List<Category> CategoryList { get; set; } = new();
        public void OnGet() // vai ser sempre executado quando a pagina estiver sendo renderizada
        {

            for (int i = 0; i < 100; i++)
            {
                CategoryList.Add(
                    new Category(i,
                     $"Categoria{i}",
                      i * 18.95M));
            }
        }
    }

    public record Category(int Id, string Title, decimal Price);

}