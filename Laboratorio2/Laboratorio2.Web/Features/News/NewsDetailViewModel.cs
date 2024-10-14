namespace Laboratorio2.Web.Features.News
{
    public class NewsDetailViewModel
    {
        public int Anno { get; set; }
        public int Mese { get; set; }
        public int Giorno { get; set; }
        public string Slug { get; set; }

        public NewsDetailViewModel()
        {
            Slug = string.Empty;
        }
    }
}
