namespace ApiDocAssistant.Domain.Entities
{
    public class ApiProject
    {
         public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public string SpecFormat { get; set; } = string.Empty; // "OpenAPI" or "Postman"
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public List<ApiEndpoint> Endpoints { get; set; } = new List<ApiEndpoint>();
    }
}