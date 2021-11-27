﻿using eShop.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShop.Models.Interfaces
{
    interface INewsRepository
    {
        IQueryable<News> NewsRepo { get; }

        void SaveNews(News news);

        News DeleteNews(int newsID);

        News GetNews(int newsID);

        IQueryable<News> LastNews();
    }
}
