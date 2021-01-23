//  BaseEntity.cs
//
// Description: 
//       <Describe here>
//  Author:
//       Ryan Xu(XuChunlei) <hitxcl@gmail.com>
//  Create at:
//       15:17:13 22/1/2021
//
//  Copyright (c) 2021 XuChunlei
using System;
namespace LNM.Core.Entities.Base
{
    public class BaseEntity<EID> : IBaseEntity<EID>
    {
        public BaseEntity()
        {
        }

        public EID Id { get; protected set; }
    }
}
