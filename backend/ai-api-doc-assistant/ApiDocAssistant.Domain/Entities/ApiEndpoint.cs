namespace ApiDocAssistant.Domain.Entities;

public class ApiEndpoint
{
    public Guid Id { get; set; }
    public Guid ApiProjectId { get; set; }
    public ApiProject ApiProject { get; set; } = null!;

    public string Path { get; set; } = string.Empty;
    public string Method { get; set; } = string.Empty; // GET, POST, etc.
    public string? Summary { get; set; }

    public List<EndpointParameter> Parameters { get; set; } = new();
}