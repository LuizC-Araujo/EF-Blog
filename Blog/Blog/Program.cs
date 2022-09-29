using System;
using System.Linq;

using Blog.Data;

using Microsoft.EntityFrameworkCore;

namespace Blog
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (var _context = new BlogDataContext())
            {
                //var tag = new Tag
                //{
                //    Name = "ASP.NET",
                //    Slug = "aspnet"
                //};

                //_context.Add(tag);
                //_context.SaveChanges();

                //var tag = _context.Tags.FirstOrDefault(x => x.Id == 1);
                //tag.Name = ".NET";
                //tag.Slug = "dotnet";

                //_context.Update(tag);
                //_context.SaveChanges();

                //var tag = _context.Tags.FirstOrDefault(x => x.Id == 1);
                //_context.Remove(tag);
                //_context.SaveChanges();

                //var tags = _context
                //    .Tags
                //    .AsNoTracking()
                //    .Where(x => x.Name.Contains(".NET"))
                //    .ToList();

                //foreach (var tag in tags)
                //{
                //    Console.WriteLine(tag.Name);
                //}

                //var tag = _context
                //    .Tags
                //    .AsNoTracking()
                //    .FirstOrDefault(x => x.Id == 3);
                
                //Console.WriteLine(tag?.Name);
            }


        }
    }
}
