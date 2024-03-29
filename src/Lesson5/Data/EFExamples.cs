﻿using Microsoft.EntityFrameworkCore;

namespace Lesson5.Data;

public class EFExamples
{
    public async void Example()
    {
        using var db = new AppDbContext(new DbContextOptions<AppDbContext>());
        Console.WriteLine("Inserting a new blog");
        db.Add(new Order { Phone = "http://blogs.msdn.com/adonet" });
        await db.SaveChangesAsync();

        // Read
        var blog = await db.Orders
            .OrderBy(b => b.Id)
            .FirstAsync();

        // Update
        blog.Phone = "https://devblogs.microsoft.com/dotnet";
        await db.SaveChangesAsync();

        // Delete
        Console.WriteLine("Delete the blog");
        db.Remove(blog);
        await db.SaveChangesAsync();
    }
}