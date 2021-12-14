using System;
namespace TechJobsOO
{
    public class Job 
    {
        public int Id { get; }
        private static int nextId = 1;
        private object id;

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        // TODO: Add the two necessary constructors.
        public Job()
        {
            id = nextId;
            nextId++;
        }
        public Job(String name, Employer employer, Location location, PositionType positionType, CoreCompetency coreCompetency)
        {

            {
                Name = name;
                EmployerName = employer;
                EmployerLocation = location;
                JobType = positionType;
                JobCoreCompetency = coreCompetency;
            }

        }
        // TODO: Generate Equals() and GetHashCode() methods.
        public override bool Equals(object obj)
        {

            return obj is Job job &&
                   id == job.id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(id);
        }
         




    }
}
