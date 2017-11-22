using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestExercise;

namespace TestExerciseTest
{
    [TestClass]
    public class FileProcessTest
    {
        [TestMethod]
        public void FileNameDoesExist()
        {
            //Arrange
            FileProcess fileProcess = new FileProcess();
            //Act
            bool fromCall;
            fromCall = fileProcess.FileExists(@"c:\\Windows\Regedit.exe");
            //Assert
            Assert.IsTrue(fromCall);
        }

        [TestMethod]
        public void FileNameDoesNotExist()
        {
            //Arrange
            FileProcess fileProcess = new FileProcess();
            //Act
            bool fromCall;
            fromCall = fileProcess.FileExists(@"c:\\badFile.bad");
            //Assert
            Assert.IsFalse(fromCall);
        }

        [TestMethod]
        public void FileNameNullOrEmpty_throwsArgumentException()
        {
            //Arrange
            FileProcess fileProcess = new FileProcess();
            //Act
            try
            {
                fileProcess.FileExists(@"c:\\badFile.bad");
            }
            catch (ArgumentNullException)
            {

                throw new ArgumentNullException(@"c:\\badFile.bad");
            }
        }
    }
}
