using IdealWeightCalc;

namespace IdealWeightCalcTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void WeightCalc_176_GenderW_63()
        {
            WeightCalc calc = new WeightCalc() { Height = 176, Gender = 'w' };

            double actual = calc.GetIdealWeight();
            double expected = 63;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void WeightCalc_170_GenderM_65()
        {
            WeightCalc calc = new WeightCalc() { Height = 170, Gender = 'M' };

            double actual = calc.GetIdealWeight();
            double expected = 65;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void WeightCalc_AnyWeight_GenderInvalid_0()
        {
            WeightCalc calc = new WeightCalc() { Height = 170, Gender = 'X' };

            double actual = calc.GetIdealWeight();
            double expected = 0;
            Assert.AreEqual(expected, actual);
        }

    }
}