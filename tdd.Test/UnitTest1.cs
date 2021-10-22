using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace tdd.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void bin2Dec()
        {
            var binicial = 2;
            var bfinal = 10;
            var valor = "101";
            var convert = new tdd.Conversor();
            var expectedResult = "5";

            var result = convert.Converter(binicial, bfinal, valor);
            Assert.AreEqual(result, expectedResult);
        }

        [TestMethod]
        public void hex2Dec()
        {
            var binicial = 16;
            var bfinal = 10;
            var valor = "f";
            var convert = new tdd.Conversor();
            var expectedResult = "15";

            var result = convert.Converter(binicial, bfinal, valor);
            Assert.AreEqual(result, expectedResult);
        }

        [TestMethod]
        public void dec2Bin()
        {
            var binicial = 10;
            var bfinal = 2;
            var valor = "5";
            var convert = new tdd.Conversor();
            var expectedResult = "101";

            var result = convert.Converter(binicial, bfinal, valor);
            Assert.AreEqual(result, expectedResult);
        }

        [TestMethod]
        public void hex2Bin()
        {
            var binicial = 16;
            var bfinal = 2;
            var valor = "f";
            var convert = new tdd.Conversor();
            var expectedResult = "1111";

            var result = convert.Converter(binicial, bfinal, valor);
            Assert.AreEqual(result, expectedResult);
        }
        [TestMethod]
        public void dec2Hex()
        {
            var binicial = 10;
            var bfinal = 16;
            var valor = "15";
            var convert = new tdd.Conversor();
            var expectedResult = "f";

            var result = convert.Converter(binicial, bfinal, valor);
            Assert.AreEqual(result, expectedResult);
        }

        [TestMethod]
        public void bin2Hex()
        {
            var binicial = 2;
            var bfinal = 16;
            var valor = "1111";
            var convert = new tdd.Conversor();
            var expectedResult = "f";

            var result = convert.Converter(binicial, bfinal, valor);
            Assert.AreEqual(result, expectedResult);
        }
    }
}
