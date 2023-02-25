using Book.Models;

namespace Book.ViewModels
{
    public class HomeVM
    {
        public List<Series> Series { get; set; }
        public List<Category> Categories { get; set; }
        public double Total { get; set; }
        public int Skip { get; set; }
        public int Limit { get; set; }
    }
}
