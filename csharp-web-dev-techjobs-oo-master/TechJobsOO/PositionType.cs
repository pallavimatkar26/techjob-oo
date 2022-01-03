using System;
namespace TechJobsOO
{
    public class PositionType:JobField
    {
        //public int Id { get; }
        //private static int nextId = 1;
        //public string Value { get; set; }

        //public PositionType()
        //{
        //    Id = nextId;
        //    nextId++;
        //}

        public PositionType(string value) : base(value) { }
        //{
            
        //        Value = value;
        //}

        //public override bool Equals(object obj)
        //{
        //    if (obj == null)
        //    {
        //        return true;
        //    }
        //    if (!(obj is PositionType))
        //    {
        //        return false;
        //    }
        //    else
        //    {
        //        return obj is PositionType positionType &&
        //                   Id == positionType.Id;
        //    }
        //}
        
        //public override int GetHashCode()
        //{
        //    return HashCode.Combine(Id);
        //}

        //public override string ToString()
        //{
            
        //    return Value;
        //}
        //// TODO: Add custom Equals(), GetHashCode(), and ToString() methods.
    }
}
