using Microsoft.EntityFrameworkCore;
using ApiDocAssistant.Domain.Entities;

namespace ApiDocAssistant.Infrastructure.Persistence;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<ApiProject> ApiProjects => Set<ApiProject>();
    public DbSet<ApiEndpoint> ApiEndpoints => Set<ApiEndpoint>();
    public DbSet<EndpointParameter> EndpointParameters => Set<EndpointParameter>();
}