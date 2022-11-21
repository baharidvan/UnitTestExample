//using Microsoft.VisualStudio.TestTools.UnitTesting; //For test1
using NUnit.Framework;
using System;
using UnitTestReservation.Fundamentals;

namespace UnitTest1
{
    #region Unit Test-1
    /*[TestClass]
    public class ReservationTests
    {
        //1.Specifies the name of the method under the test
        //2.The scenario we're testing
        //3.Expected Behavior.
        [TestMethod]
        public void CanBeCanceledBy_UserIsAdmin_ReturnsTrue()
        {
            // Arrange: Initialize our object
            var reservation = new Reservation();

            // Act: Call the method we are gonna test
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });

            // Assert: verify the result is correct
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void CanBeCanceledBy_SameUserCancelingTheReservation_ReturnsTrue()
        {
            // Arrange
            var user = new User();
            var reservation = new Reservation { MadeBy = user };
            // Act
            var result = reservation.CanBeCancelledBy(user);
            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanBeCancelledBy_AnotherUserCanceling_ReturnsFalse()
        {
            // Arrange
            var reservation = new Reservation { MadeBy = new User() };
            // Act
            var result = reservation.CanBeCancelledBy(new User());
            // Assert
            Assert.IsFalse(result);
        }
    }*/
    #endregion

    #region Unit Test 2 - NUnit Test

    [TestFixture]
    public class ReservationTests
    {
        //1.Specifies the name of the method under the test
        //2.The scenario we're testing
        //3.Expected Behavior.
        [Test]
        public void CanBeCanceledBy_UserIsAdmin_ReturnsTrue()
        {
            var reservation = new Reservation();

            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });

            //Assert.IsTrue(result);
            Assert.That(result, Is.True);
            //Assert.That(result == true);
        }
        [Test]
        public void CanBeCanceledBy_SameUserCancelingTheReservation_ReturnsTrue()
        {
            // Arrange
            var user = new User();
            var reservation = new Reservation { MadeBy = user };
            // Act
            var result = reservation.CanBeCancelledBy(user);
            // Assert
            //Assert.IsTrue(result);
            Assert.That(result, Is.True);
        }

        [Test]
        public void CanBeCancelledBy_AnotherUserCanceling_ReturnsFalse()
        {
            // Arrange
            var reservation = new Reservation { MadeBy = new User() };
            // Act
            var result = reservation.CanBeCancelledBy(new User());
            // Assert
            //Assert.IsFalse(result);
            Assert.That(result, Is.False);
        }
    }

    #endregion
}
