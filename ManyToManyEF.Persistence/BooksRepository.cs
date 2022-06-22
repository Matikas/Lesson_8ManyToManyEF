﻿using ManyToManyEF.Persistence.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyToManyEF.Persistence
{
    public class BooksRepository
    {
        private readonly BooksContext _dbContext = new BooksContext();

        public void CreateCategory(Category category)
        {
            _dbContext.Categories.Add(category);
        }

        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }
    }
}
