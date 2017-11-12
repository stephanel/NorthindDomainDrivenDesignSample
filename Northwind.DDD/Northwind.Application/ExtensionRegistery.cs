﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Northwind.Application.Database;
using Northwind.Application.Employees;
using Northwind.Application.Services;
using Northwind.Domain.Employees;
using Northwind.Framework.Helpers;

namespace Northwind.Application
{
    public static class ExtensionRegistery
    {
        public static void AddNorthwind(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<DbContext, NorthwindDbContext>();
            serviceCollection.AddScoped<IUnitOfWork, UnitOfWork>();
            serviceCollection.AddScoped<IEmployeeRepository, EmployeeRepository>();
            serviceCollection.AddScoped<EmployeeService, EmployeeService>();
        }
    }
}