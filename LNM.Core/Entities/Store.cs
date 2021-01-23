//  Store.cs
//
// Description: 
//       <Describe here>
//  Author:
//       Ryan Xu(XuChunlei) <hitxcl@gmail.com>
//  Create at:
//       20:24:20 23/1/2021
//
//  Copyright (c) 2021 XuChunlei
using System;
using LNM.Core.Entities.Base;

namespace LNM.Core.Entities
{
    public class Store : Entity
    {
        public string Name { get; set;  }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public Store()
        {
        }
    }
}
