using System;
using System.Collections.Generic;
using System.Text;

namespace TechJobsOO
{
    public abstract class JobField
    {
        protected int id;
        protected static int nextId = 1;
        protected string Value { get; set; }

        public JobField()
        {
            id = nextId;
            nextId++;
        }
        public JobField(String value):this()
        {

           

                Value = value;

        }

        public override bool Equals(object obj)
        {
            return obj is JobField field &&
                   id == field.id &&
                   Value == field.Value;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(id, Value);
        }
    }

}

