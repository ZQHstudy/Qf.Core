﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Qf.Core.Infrastructure
{
    public abstract class AuditedEntity : CreationAuditedEntity
    {
        public virtual DateTime? LastModificationTime { get; set; }

        public virtual Guid? LastModifierId { get; set; }
    }

    public abstract class AuditedEntity<TKey> : CreationAuditedEntity<TKey>
    {
        public virtual DateTime? LastModificationTime { get; set; }

        public virtual Guid? LastModifierId { get; set; }

        protected AuditedEntity()
        {

        }

        protected AuditedEntity(TKey id)
            : base(id)
        {

        }
    }
}
