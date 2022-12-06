﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Due_It
{
    public class SystemProperties
    {
        [PrimaryKey, AutoIncrement]
        public int? ID { get; set; }

        public SystemProperties()
        {
            ID = 0;
        }
        public SystemProperties(int? iD)
        {
            ID = iD;
        }
    }
}
