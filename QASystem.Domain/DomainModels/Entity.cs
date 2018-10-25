using System;
using System.Collections.Generic;
using System.Text;

namespace QASystem.Models.DomainModels
{
    public abstract class Entity
    {
        public Guid Id { get; set; }

        protected Entity(Guid id)
        {
            this.Id = id;
        }
    }
}
