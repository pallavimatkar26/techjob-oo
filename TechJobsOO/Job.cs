using DocumentFormat.OpenXml.Office2010.Excel;
using System;
namespace TechJobsOO
{
    public class Job :JobField
    {
        public int idValue { get; }
        private static int nextId = 1;
        private object id;

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }
        public string nameValue { get; private set; }

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
        public override string ToString()

        {
            if ((id == null)
                   &&  (Name == null)
                    && (EmployerName == null)
                    && (EmployerLocation == null)
                    && (JobType == null)
                    && (JobCoreCompetency == null))
           
              
           {
               return "OOPS! This job does not seem to exist.";
            }
            String nameValue = Name;
            String employerValue = EmployerName.ToString();
            String locationValue = EmployerLocation.ToString(); ;
            String positionTypeValue = JobType.ToString();
            String coreCompetencyValue = JobCoreCompetency.ToString();
           
            if(employerValue==null)
            {
                employerValue = "Data not available";
            }
            if (locationValue == null)
            {
                locationValue= "Data not available";
            }
            if(positionTypeValue==null)
            {
                positionTypeValue= "Data not available";
            }
            if(coreCompetencyValue==null)
                coreCompetencyValue= "Data not available";

            return "\nID: " + idValue + "\nName: " + nameValue + "\nEmployer: "
                + employerValue + "\nLocation: " + locationValue
                + "\nPosition Type: " + positionTypeValue
                + "\nCore Competency: " + coreCompetencyValue + "\n";
        }
       

    }
}
