// See https://aka.ms/new-console-template for more information

using eCommerceBot.Domains.Entities;
using eCommerceBot.Infrastructure;
using eCommerceBot.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Hello, World!");
AppDataContext dataContext = new AppDataContext();
UserRepository user = new UserRepository(dataContext);
ProductRepository product= new ProductRepository(dataContext);
var result =await product.CreatAsync(new Product
{
    Name = null,
    PhotoUrl = null,
    ImageId = null,
    Price = 0,
    Count = 0,
    CategoryId = 0,
    Category = null,
});
Console.WriteLine(result.Id);