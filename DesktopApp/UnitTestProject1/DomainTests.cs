using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesktopLibary;
using DesktopLibary.Models;

namespace UnitTestProject1
{
   [TestClass]
   public class DomainTests
   {

      /// <summary>
      /// 
      /// </summary>
      [TestMethod]
      public void DomainAddPositiveTest()
      {
         //arrange
         bool actual;
         bool expected =  true;
         var dh = new DomainHelper();
         var p = new Person()
         {
            FirstName = "Zach",
            LastName = "Johnson",
            PhoneNumber = "434-284-0595",
            Address = new Location() { Street = "930 Turner Mtn. Rd.", City = "Charlottesville", State = "VA", Areacode = 22903 }
         };

         //act
         

         //Assert
         //Assert.AreEqual(expected, actual);
         
      }


      /// <summary>
      /// 
      /// </summary>
      [TestMethod]   
      public void DomainAddNegativeTest()
      {
         //arrange
         bool actual;
         bool expected = false;
         var dh = new DomainHelper();
         var p = new Person()
         {
            FirstName = null,
            LastName = "Johnson",
            PhoneNumber = "434-284-0595",
            Address = new Location() { Street = "930 Turner Mtn. Rd.", City = "Charlottesville", State = "VA", Areacode = 22903 }
         };

         //act
         

         //Assert
         //Assert.AreEqual(expected, actual);
         
      }



      /// <summary>
      /// 
      /// </summary>
      [TestMethod]
      public void DomainDeletePositive()
      {
         //arrange
         bool actual;
         bool expected = true;
         var dh = new DomainHelper();
         var p = new Person()
         {
            FirstName = "Zach",
            LastName = "Johnson",
            PhoneNumber = "434-284-0595",
            Address = new Location() { Street = "930 Turner Mtn. Rd.", City = "Charlottesville", State = "VA", Areacode = 22903 }
         };

         //act
         

         //Assert
         //Assert.AreEqual(expected, actual);
      }



      /// <summary>
      /// 
      /// </summary>
      [TestMethod]
      public void DomainDeleteNegative()
      {

         //arrange
         bool actual;
         bool expected = false;
         var dh = new DomainHelper();
         var p = new Person()
        {
           FirstName = null,
           LastName = "Johnson",
           PhoneNumber = "434-284-0595",
           Address = new Location() { Street = "930 Turner Mtn. Rd.", City = "Charlottesville", State = "VA", Areacode = 22903 }
        };
         //act
         

         //Assert
         //Assert.AreEqual(expected, actual);
      }



      /// <summary>
      /// 
      /// </summary>
      [TestMethod]
      public void DomainSavePositiveTest()
      {
         //arrange
         bool actual;
         bool expected = true;
         var dh = new DomainHelper();
         var p = new Person()
         {
            FirstName = "Zach",
            LastName = "Johnson",
            PhoneNumber = "434-284-0595",
            Address = new Location() { Street = "930 Turner Mtn. Rd.", City = "Charlottesville", State = "VA", Areacode = 22903 }
         };

         //act
         DomainHelper.Add

         //Assert
         //Assert.AreEqual(expected, actual);
      }



      /// <summary>
      /// 
      /// </summary>
      [TestMethod]
      public void DomainRetrieveTest()
      {
         //arrange
         var expected = "Zach Johnson";
         string actual;
         var dh = new DomainHelper();

         //act
         

         //assert
         //Assert.AreEqual(expected, actual);
         
      }

   }
}
