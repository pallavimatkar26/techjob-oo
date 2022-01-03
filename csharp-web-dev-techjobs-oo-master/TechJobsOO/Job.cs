using DocumentFormat.OpenXml.Office2010.Excel;
using System;
namespace TechJobsOO
{
    public class Job 
    {
        public int Id { get; }
        private static int nextId = 1;
       

        public string Name { get; set; }
        public Employer Employer { get; set; }
        public Location Location { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }
        public string employer { get; set; }


        // TODO: Add the two necessary constructors.
        public Job()
        {
            Id = nextId;
            nextId++;
        }
        public Job(String name, Employer employer, Location location, PositionType positionType, CoreCompetency coreCompetency):this()
        {

            {
                Name = name;
                Employer = employer;
                Location = location;
                JobType = positionType;
                JobCoreCompetency = coreCompetency;
            }

        }
        // TODO: Generate Equals() and GetHashCode() methods.
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return true;
            }
            if ((obj is Job) != (obj is Job))
                return false;
            else
            {
                return obj is Job job &&
                       Id == job.Id;
            }
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
        public override string ToString()

        {
            if ((Id == null)
                   &&  (Name == null)
                    && (Employer == null)
                    && (Location == null)
                    && (JobType == null)
                    && (JobCoreCompetency == null))
           
              
           {
               return "OOPS! This job does not seem to exist.";
            }
            
            String name = Name;
            String employer = Employer.ToString();
            String location = Location.ToString(); ;
            String positionType = JobType.ToString();
            String coreCompetency = JobCoreCompetency.ToString();
            if (name == null || name == "")
            {
                name = "Data not available";
            }
            if (employer==null || employer=="")
            {
                employer = "Data not available";
            }
            if (location == null ||  location=="")
            {
                location= "Data not available";
            }
            if(positionType==null || positionType=="")
            {
                positionType= "Data not available";
            }
            if(coreCompetency==null || coreCompetency =="")
                coreCompetency= "Data not available";

            return "\nID: " + Id +
                "\nName: " + name +
                "\nEmployer: " + employer + 
                "\nLocation: " + location +
                "\nPosition Type: " + positionType +
                "\nCore Competency: " + coreCompetency + "\n";
        }
       

    }
}
