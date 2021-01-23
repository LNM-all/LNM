//  Category.cs
//
// Description: 
//       <Describe here>
//  Author:
//       Ryan Xu(XuChunlei) <hitxcl@gmail.com>
//  Create at:
//       22:32:35 23/1/2021
//
//  Copyright (c) 2021 XuChunlei
using System;
using System.ComponentModel.DataAnnotations;
using LNM.Core.Entities.Base;

namespace LNM.Core.Entities
{
    public class Category : Entity
    {
        [Required, StringLength(50)]
        public string Name { get; set; }
        public Category()
        {
        }
    }
}
