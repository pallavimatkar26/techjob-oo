﻿using System;
namespace TechJobsOO
{
    public class Location:JobField
    {
        //public int Id { get; }
        //private static int nextId = 1;
        //public string Value { get; set; }

        //public Location()
        //{
        //    Id = nextId;
        //    nextId++;
        //}

        public Location(string value) : base(value) { }
        //{

        //    Value = value;
        //}
        // TODO: Add a second constructor to this class that uses the Location() constructor and sets the value of the value field.

        //public override bool Equals(object obj)
        //{
        //    if (obj == null)
        //    {
        //        return true;
        //    }
        //    if (!(obj is Location))
        //    {
        //        return false;
        //    }
        //    else
        //    {
        //        return obj is Location location &&
        //               Id == location.Id;
        //    }     
        //}
        //public override int GetHashCode()
        //{
        //    return HashCode.Combine(Id);
        //}

        //public override string ToString()
        //{
        //    return  Value;
        //    //return Value;
        //}
    }
}
