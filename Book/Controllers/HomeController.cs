using Book.Models;
using Microsoft.AspNetCore.Mvc;
using Book.ViewModels;


namespace Book.Controllers
{
    public class HomeController:Controller
    {
        public List<Series> Series;
        public List<Category> Categories;
        public HomeController()
        {
            Series = new List<Series>()
            {
                new Series()
                {
                    Id = 1,
                    Name = "Legend 2015",
                    CoverPhoto = "https://avatars.mds.yandex.net/get-entity_search/2362199/472339738/S134x201_2x",
                    Imdb = 9.9,
                    Desc = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum."
                },
                 new Series()
                {
                    Id = 2,
                    Name = "Split",
                    CoverPhoto = "https://avatars.mds.yandex.net/get-ott/224348/2a0000016128d643200cf0ca15a7291b7abb/140x210",
                    Imdb = 8.6,
                    Desc = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum."
                },
                  new Series()
                {
                    Id = 3,
                    Name = "Glasses",
                    CoverPhoto = "https://avatars.mds.yandex.net/get-entity_search/2102351/473307452/S134x201_2x",
                    Imdb = 8.5,
                    Desc = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum."
                },
                   new Series()
                {
                    Id = 4,
                    Name = "Brigada",
                    CoverPhoto = "https://avatars.mds.yandex.net/get-entity_search/117753/122710138/S134x201_2x",
                    Imdb = 9.9,
                    Desc = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum."
                },
                    new Series()
                {
                    Id = 5,
                    Name = "Bumer",
                    CoverPhoto = "https://avatars.mds.yandex.net/get-entity_search/2044927/472832430/S134x201_2x",
                    Imdb = 9.9,
                    Desc = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum."
                },
                     new Series()
                {
                    Id = 6,
                    Name = "Invulnerable",
                    CoverPhoto = "https://avatars.mds.yandex.net/get-entity_search/2371583/483055818/S134x201_2x",
                    Imdb = 9.0,
                    Desc = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum."
                },   
            };

            Category cat1 = new Category()
            {
                Id = 1,
                Name = "Series"
            };
  
            Categories = new List<Category>()
            {
                cat1,

            };
        }
        public IActionResult Index()
        {
           
            HomeVM model = new HomeVM
            {
                Categories = Categories,
                Series = Series,
                Total = 10,
                Skip = 20,
                Limit = 30
            };
            return View(model);
        }
    }
}


      
