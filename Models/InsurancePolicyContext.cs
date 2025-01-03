using Microsoft.EntityFrameworkCore;

namespace InsurancePolicyAPIBackend.Models;

public class PolicyDbContext : DbContext
{
    public PolicyDbContext(DbContextOptions<PolicyDbContext> options) : base(options) { }

    public DbSet<InsurancePolicy> InsurancePolicies { get; set; } = null!;
}


