namespace WebStore.Core.Models
{
    public class BookCardModel
    {
        public int Id { get; set; }

        public required string Title { get; set; }

        public required string ImgPath { get; set; }
        
        public required string Autor { get; set; }

        public decimal Price { get; set; }

    }
}
