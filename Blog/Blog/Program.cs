using System;
using System.Linq;

using Blog.Data;
using Blog.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog
{
    public class Program
    {
        static void Main(string[] args)
        {
            using var _context = new BlogDataContext();

            //var user = new User
            //{
            //    Name = "Luiz Araujo",
            //    Slug = "luizaraujo",
            //    Email = "luiz@araujo.com",
            //    Bio = "Dev",
            //    Image = "https://image",
            //    PasswordHash = "123456"
            //};

            //var category = new Category
            //{
            //    Name = "Backend",
            //    Slug = "backend"
            //};

            //var post = new Post
            //{
            //    Author = user,
            //    Category = category,
            //    Body = "<h1>Asp Net</h1>",
            //    Slug = "comecando-com-ef-Core",
            //    Summary = "Vamos aprender EF Core",
            //    Title = "Começando com EF Core",
            //    CreateDate = DateTime.Now,
            //    LastUpdateDate = DateTime.Now
            //};

            //_context.Posts.Add(post);
            //_context.SaveChanges();

            var posts = _context
                .Posts
                .AsNoTracking()
                .Include(x => x.Author)
                .OrderByDescending(x => x.LastUpdateDate)
                .ToList();

            foreach (var post in posts)
            {
                Console.WriteLine($"{post.Title} escrito por {post.Author?.Name}");
            }
        }
    }
}
