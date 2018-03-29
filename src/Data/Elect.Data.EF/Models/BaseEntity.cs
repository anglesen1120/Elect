﻿#region	License
//--------------------------------------------------
// <License>
//     <Copyright> 2018 © Top Nguyen </Copyright>
//     <Url> http://topnguyen.net/ </Url>
//     <Author> Top </Author>
//     <Project> Elect </Project>
//     <File>
//         <Name> BaseEntity.cs </Name>
//         <Created> 24/03/2018 10:00:54 PM </Created>
//         <Key> fb25499f-ebfb-4875-828e-967851c06aba </Key>
//     </File>
//     <Summary>
//         BaseEntity.cs is a part of Elect
//     </Summary>
// <License>
//--------------------------------------------------
#endregion License

using Elect.Data.EF.Interfaces.Entity;
using Elect.Data.EF.Interfaces.Entity.Auditable;
using Elect.Data.EF.Interfaces.Entity.SoftDelete;
using System;

namespace Elect.Data.EF.Models
{
    public abstract class BaseEntity : IGlobalIdentityEntity, ISoftDeletableEntity, IAuditableEntity
    {
        protected BaseEntity()
        {
            CreatedTime = LastUpdatedTime = DateTimeOffset.UtcNow;
        }

        public Guid GlobalId { get; set; } = Guid.NewGuid();

        public DateTimeOffset CreatedTime { get; set; }

        public DateTimeOffset LastUpdatedTime { get; set; }

        public DateTimeOffset? DeletedTime { get; set; }
    }
}