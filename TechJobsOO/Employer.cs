using System;
namespace TechJobsOO
{
    public class Employer
    {
        public int Id { get; }
        private static int nextId = 1;
        private object id;
        
        public string Value { get; set; }

        public Employer()
        {
            

                Id = nextId;
                nextId++;
                
        }

        public Employer(string value) : this()

        {
            
                Value = value;
            
        }


        public override bool Equals(object obj)
        {
            
                             
                return obj is Employer employer &&
                       id == employer.id;
                
            
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            return Id.ToString();
        }
    }
}
