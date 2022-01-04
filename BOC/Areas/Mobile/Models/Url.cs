﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BOC.Areas.Mobile.Models
{
    public class Url
    {
        #if DEBUG
                private const string boc_api = "http://boc_Api.bambooairways.com:8080/";
        #else
                private const string boc_api = "http://boc_Api.bambooairways.com/";
        #endif

        internal string Get(string name)
        {
            return boc_api + name;
        }
    }
}
