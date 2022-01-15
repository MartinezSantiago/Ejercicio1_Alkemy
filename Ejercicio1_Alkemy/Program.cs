using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ejercicio1_Alkemy
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
    public class User
    {
        /* Id.
 Name
 Password
 Email.
 Posts
 Comments*/
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public virtual List<Post> Posts { get; set; }
        public virtual List<Comment> Comments { get; set; }
    }
    public class Post
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Content { get; set; }

        public User User { get; set; }
       

    }
    public class Comment
    {

        [Key]
        public int Id { get; set; }
        public DateTime Date { get; set; }
        [Column("Comment")]
        public string Comment1 { get; set; }
        public Post Post { get; set; }

        public User User { get; set; }


    }
    public class Ejercicio1_Alkemy:DbContext
    {
        public Ejercicio1_Alkemy() : base() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=Ejercicio1_Alkemy;Persist Security Info=True;User ID=sa;Password=290303portela;");
        }


        DbSet<User> Users { get; set; }
        DbSet<Post> Posts { get; set; }
        DbSet<Comment> Comments { get; set; }
       
    }
}
