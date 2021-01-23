//  Spu.cs
//
// Description: 
//       <Describe here>
//  Author:
//       Ryan Xu(XuChunlei) <hitxcl@gmail.com>
//  Create at:
//       22:35:25 23/1/2021
//
//  Copyright (c) 2021 XuChunlei
using System;
using System.ComponentModel.DataAnnotations;
using LNM.Core.Entities.Base;

namespace LNM.Core.Entities
{
    public class Spu : Entity
    {
        [Required, StringLength(50)]
        public string Name { get; set; }
        public string Image { get; set; }

        // n - 1 relationship : spu - category
        [Required]
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        // n - 1 relationship : spu - brand (null means no brand)
        public int BrandId { get; set; }
        public Brand Brand { get; set; }
        

        public Spu()
        {
        }
    }
}
