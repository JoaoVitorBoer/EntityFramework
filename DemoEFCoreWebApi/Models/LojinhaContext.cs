namespace DemoEFCoreWebApi.Models;

using Microsoft.EntityFrameworkCore;
public class LojinhaContext : DbContext
{
    public LojinhaContext()
    {
    }
    public LojinhaContext(DbContextOptions<LojinhaContext> options) //As configs do lojinhacontext vem do program.cs
    : base(options)
    {  
        
    }
}