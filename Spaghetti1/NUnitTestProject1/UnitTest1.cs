using NUnit.Framework;
using Spaghetti1;

namespace NUnitTestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            
        }
        [TestCase(3, 4, 2, 2, "Kawa; du¿a 200 ml; z mlekiem 100 ml; z cukrem 2 kostki.")]
        [TestCase(1, 3, 3, 0,"Woda; œrednia 150 ml; z mlekiem 150 ml; bez cukru.")]
        [TestCase(2, 2, 0, 2, "Herbata; mala 100 ml; bez mleka; z cukrem 2 kostki.")]
        [TestCase(4, 1, 1, 0,"Porcja soku; mala 50 ml; z mlekiem 50 ml; bez cukru.")]
        [TestCase(1, 3, 3, 3, "Woda; œrednia 150 ml; z mlekiem 150 ml; z cukrem 3 kostki.")]
        [TestCase(1, 2, 4, 0, "Woda; mala 100 ml; z mlekiem 200 ml; bez cukru.")]
        [TestCase(1, 1, 4, 2, "Woda; mala 50 ml; z mlekiem 200 ml; z cukrem 2 kostki.")]
        [TestCase(3, 5, 2, 1, "Kawa;  0 ml; z mlekiem 100 ml; z cukrem 1 kostka.")]
        public void Test(int drink, int drinkSize, int milkSize, int shugarSize, string txt)
        {
            Drink _drink = new Drink(drink,drinkSize, milkSize, shugarSize);
            var result = _drink.Create();
            var expected = txt;

            StringAssert.AreEqualIgnoringCase(expected, result);
        }

    }
}