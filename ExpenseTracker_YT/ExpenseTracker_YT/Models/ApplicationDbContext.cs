using Microsoft.EntityFrameworkCore;

namespace ExpenseTracker_YT.Models;

/// <summary>
/// Classe para interagir com o banco de dados. 
/// </summary>
public class ApplicationDbContext : DbContext
{
    /// <summary>
    /// Isso é um construtor padrão da classe
    /// DbContextOptions options = Esse construtor aceita o parâmetro do tipo DbContextOptions, que é usado para
    /// configurar o contexto do banco de dados.
    /// base serve para apenas chamar o construtor com os mesmo parâmetros. 
    /// </summary>
    public ApplicationDbContext(DbContextOptions options):base(options) {}
        
    /// <summary>
    /// DbSet representa uma coleção de entidades do tipo especificado.
    /// Isso significa que o ApplicationDbContext vai mapear a tabela de Transaction no banco de dados para um conjuntos
    /// de objetos na tabela Transations. Isso facilita operações como inserção, atualização, exclusão e consulta de dados
    /// relacionados a Transaction. 
    /// </summary>
    public DbSet<Transaction> Transactions { get; set; }
    /// <summary>
    /// Assim como Transaction, isso representa uma coleção de entidades Category que serão mapeadas para a
    /// tabela Categories no bando de dados. 
    /// </summary>
    public DbSet<Category> Categories { get; set; }
}
