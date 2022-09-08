using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void BookCalculatesAnAverageGrade()
        {
            // arrange 
            var book = new Book("");
            book.AddGrade(89.1);
            book.AddGrade(19.1);

            // act 
            var result = book.GetStatistics();
            // assert
            Assert.Equal(45.8 , result.Average, 1);
            Assert.Equal(89.1, result.High, 1);
            Assert.Equal(19.1, result.Low, 1);
            Assert.Equal('F', result.Letter);
        }
    }
}
