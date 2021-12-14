//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System;
//using System.Collections.Generic;


//namespace TechJobsTests
//{
//    [TestClass]
//    public class JobTest
//    {
//        public Job job1;
//        public Job job2;
//        public void initialize()
//        {
//            job1 = new Job();
//            job2 = new Job();
//        }
//        [TestMethod]
//        public void TestSettingJobId()

//        {
//            Assert.AreEqual(job1.id + 1, job2.id);
//        }
//        [TestMethod]
//        public void testJobConstructorSetsAllFields()
//        {
//            Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
//            Assert.AreEqual("Product tester", job1.Name);
//            Assert.IsTrue(job1.Employer, job1.Employer);
//            Assert.AreEqual("ACME", job1.Employer.ToString());
//            Assert.IsTrue(job1.Location, job1.Location);
//            Assert.AreEqual("Desert", job1.Location.ToString());
//            Assert.IsTrue(job1.PositionType, job1.PositionType);
//            Assert.AreEqual("Quality Control", job1.PostionType.ToString());
//            Assert.IsTrue(job1.CoreCompetency, job1.CoreCompetency);
//            Assert.AreEqual("Persistence", job1.CoreCompetency.ToString());


//        }
//        [TestMethod]
//        public void testJobsForEquality()
//        {
//            Job testJob = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
//            Job testJob2 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
//            Assert.IsFalse(testJob.equals(testJob2));
//        }
//    }
//}


