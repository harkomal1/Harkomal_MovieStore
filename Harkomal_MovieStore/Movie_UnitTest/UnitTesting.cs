using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyMovieStore;
namespace Movie_UnitTest
{
    [TestClass]
    public class UnitTesting
    {
        MovieRental obj_movie = new MovieRental();
        [TestMethod]
        public void LessThan5YearTest()
        {
            var actual = obj_movie.FeeCalculation(2017, 2021);
            Assert.AreEqual(expected: 5, actual);
        }
        [TestMethod]
        public void MoreThan5YearTest()
        {
            var actual = obj_movie.FeeCalculation(2011, 2021);
            Assert.AreEqual(expected: 2, actual);
        }
    }
}
