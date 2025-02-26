using System.Runtime.InteropServices;
using KungligaRPG.Models;

namespace KRPGTesting
{
    public class UnitTest1
    {
        [Fact]
        public void PrimaryAttrCurrIsIntTopIsInt()
        {
            PrimaryAttribute attr = new PrimaryAttribute("Test", 3, 5);
            Assert.IsType<int>(attr.currValue);
            Assert.IsType<int>(attr.topValue);
        }

        [Fact]
        public void SecondaryAttrCurrIsIntTopIsInt()
        {
            SecondaryAttribute attr = new SecondaryAttribute("Test", 3, 5);
            Assert.IsType<int>(attr.currValue);
            Assert.IsType<int>(attr.topValue);
        }

        [Fact]
        public void BaseAttrCurrIsIntTopIsInt()
        {
            BaseAttribute attr = new BaseAttribute("Test", 3, 5);
            Assert.IsType<int>(attr.currValue);
            Assert.IsType<int>(attr.topValue);
        }

        [Fact]
        public void TextAttrCurrIsStringTopIsNull()
        {
            TextAttribute attr = new TextAttribute("Test", "Name");
            Assert.IsType<string>(attr.currValue);
            Assert.Null(attr.topValue);
        }
    }
}
