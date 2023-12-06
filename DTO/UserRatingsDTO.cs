namespace FashionHexa.DTO
{
    public class UserRatingsDTO
    {
        public int? UserRatingsId { get; set; }
        public int? Ratings { get; set; }

        public DateTime RatedAt { get; set; }
        public string? ProductId {  get; set; }
        public string? UserId {  get; set; }
    }
}
