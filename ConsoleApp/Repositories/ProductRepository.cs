using ConsoleApp.Contexts;
using ConsoleApp.Entities;
using ConsoleApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class ProductRepository : Repo<ProductEntity>
{
    public ProductRepository(DataContext context) : base(context)
    {
    }
}