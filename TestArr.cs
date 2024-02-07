using Project2;

namespace TestDD
{
    [TestClass]
    public class UnitTest1
    {
        [DataRow(new int[] { 4, 6, 7, 8 },8,true)] 
        [TestMethod]
        public void TestMethod1(int[]ar, int number,bool expectedOutput)
        {
           
            KineretArray kr = new KineretArray(ar);
            bool b = kr.Find(number);
            Assert.AreEqual(b,expectedOutput);
            
        }
        [DataRow(null, 8)]
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void TestWithException(int[]ar,int number)
        {
            KineretArray kr = new KineretArray(ar);
            bool b = kr.Find(number);
         //   Assert.ThrowsException<NullReferenceException>
        }
    }
}