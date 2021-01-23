//  IBaseEntity.cs
//
// Description: 
//       <Describe here>
//  Author:
//       Ryan Xu(XuChunlei) <hitxcl@gmail.com>
//  Create at:
//       15:15:21 22/1/2021
//
//  Copyright (c) 2021 XuChunlei
using System;
namespace LNM.Core.Entities.Base
{
    public interface IBaseEntity<EID>
    {
        EID Id { get; }
    }
}
