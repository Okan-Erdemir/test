﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test.Data;

namespace test.Repository
{
    class FileLogger : ILogger
    {
        public void writelog(string msg)
        {
            Console.WriteLine(string.Format($"FileLogger  :{msg}"));
        }
    }
}
