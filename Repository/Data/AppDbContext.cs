using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Data
{
    public static class AppDbContext<T>
    {
        public static List<T> Datas { get; }
        static AppDbContext()
        {
            Datas = new List<T>();
        }
    }
}
