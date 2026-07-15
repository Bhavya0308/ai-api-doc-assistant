namespace ApiDocAssistant.Domain.Entities;

public class EndpointParameter
{
    public Guid Id { get; set; }
    public Guid ApiEndpointId { get; set; }
    public ApiEndpoint ApiEndpoint { get; set; } = null!;

    public string Name { get; set; } = string.Empty;
    public string In { get; set; } = string.Empty; // "query", "path", "header", "body"
    public string Type { get; set; } = string.Empty;
    public bool Required { get; set; }
}