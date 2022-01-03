using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;
using System.Diagnostics;
using TechJobsOO;

namespace TechJobsTests
{
    namespace TechJobsTests
    {
        [TestClass]
        public class JobTest
        {
            public Job job1;
            public Job job2;
            [TestInitialize]
            public void initialize()
            {
                job1 = new Job();
                job2 = new Job();
            }

            [TestMethod]
            public void TestSettingJobId()

            {
                Assert.AreEqual(job1.Id+1, job2.Id);
            }
            [TestMethod]
            public void testJobConstructorSetsAllFields()
            {
                Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality Control"), new CoreCompetency("Persistence"));
                Assert.AreEqual("Product tester", job1.Name);
                Assert.AreEqual("ACME", job1.Employer.Value);
                Assert.AreEqual("Desert", job1.Location.Value);
                Assert.AreEqual("Quality Control", job1.JobType.Value);
                Assert.AreEqual("Persistence", job1.JobCoreCompetency.Value);


            }
            [TestMethod]
            public void testJobsForEquality()
            {
                Job testJob = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
                Job testJob2 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
                Assert.IsFalse(testJob.Equals(testJob2));
            }
            [TestMethod]
            public void testToStringForBlankLines()
            {

                Job job = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
                char[] Arr=job.ToString().ToCharArray();
                Assert.AreEqual('\n',Arr[0]);
                Assert.AreEqual('\n',Arr[Arr.Length-1]);
                Assert.IsTrue(job.ToString().StartsWith('\n'));
            }
            [TestMethod]
            public void testToStringForLabelsAndFields()
            {
                Job job = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
                Assert.AreEqual("\nID: " + job.Id + "\nName: Product tester\nEmployer: ACME\nLocation: Desert\nPosition Type: Quality control\nCore Competency: Persistence\n", job.ToString());
            }

            [TestMethod]
            public void testEmptyStringInEmployerField()
            {
                Job job = new Job("Product tester", new Employer(""), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
                Assert.AreEqual("\nID: " + job.Id + "\nName: Product tester\nEmployer: Data not available\nLocation: Desert\nPosition Type: Quality control\nCore Competency: Persistence\n", job.ToString());
            }


        }
    }
}
