﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.Services.NewsFolder.Entities;

namespace BusinessLogic.Services.NewsFolder
{
    public interface INewsService
    {
        List<News> GetAll(Expression<Func<News, bool>> predicate);

        List<News> GetMainNews(Expression<Func<News, bool>> predicate);

        List<News> GetSecondaryNews(Expression<Func<News, bool>> predicate);
    }
}
