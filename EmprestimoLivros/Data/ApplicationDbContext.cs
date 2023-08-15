using EmprestimoLivros.Models;
using Microsoft.EntityFrameworkCore;

namespace EmprestimoLivros.Data
{
    //Nessa classe será realizado a correlação com o Entity Framework.
   
    public class ApplicationDbContext :DbContext // Essa classe herda o DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) //A option pega os options do DbContext.
        { 
        } 

        //Forma de criar a tabela e como criar uma propriedade
        public DbSet<EmprestimosModel> Emprestimos { get; set; }//Tabela com estrutura Emprestimos chamada Emprestimos.
  
    }
}
