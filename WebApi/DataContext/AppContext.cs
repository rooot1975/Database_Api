﻿using Microsoft.EntityFrameworkCore;

namespace WebApi.DataContext
{
    public class AppContext : DbContext
    {
        public AppContext()
        {

        }

        public AppContext(DbContextOptions<AppContext> options): base(options)
        {

        }
    }
}
