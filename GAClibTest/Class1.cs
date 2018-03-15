using GAClib;

namespace GAClibTest
{
    public class DemonstrationClass
    {
        TestClass test = new TestClass();

        public void DemonstrationRandomMethod()
        {
            string s = test.RandomMethod();
        }

        public void DemonstationRandomMethodWithParams()
        {
            string s = test.RandomMethodWithParams(15, "Hello");
        }
    }
}
