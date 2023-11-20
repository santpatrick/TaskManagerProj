using Microsoft.EntityFrameworkCore;

namespace API.models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
        : base(options){}


        //Definir quais as classes de modelo servirão para as         
        //tabelas no banco de dados
        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Tarefa> Tarefas { get; set; }

        public DbSet<Status> Status { get; set; }              


    }
}