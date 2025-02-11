using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace KungligaRPG.Models
{
    abstract public class Attribute
    {
        public string attrName {  get; set; }
        public int value { get; set; }

        public Attribute() { attrName = "";  value = 0; }
        public Attribute(string attrName, int value) { this.attrName = attrName;  this.value = value; }
    }

    public class PrimaryAttribute : Attribute
    {
        private int capValue { get; set; }

        public PrimaryAttribute() { capValue = 5; }
        
        //value: what the character has. Capvalue: what the character can get to (default 5)
        public PrimaryAttribute(string attrName, int value, int capValue)
                                : base(attrName, value) { this.capValue = capValue; }

        private void validAdjustUnderCap(int adjust) 
        { 
            if (value + adjust > capValue)
                throw new ArithmeticException(
                    "Cannot increase primary attribute " + attrName + " over cap(" + capValue + ")." );
        }

        private void validSetUnderCap(int newValue)
        {
            if (newValue > capValue)
                throw new ArithmeticException(
                    "Cannot set primary attribute " + attrName + " over cap(" + capValue + ").");
        }
    }

    public class SecondaryAttribute : Attribute
    {
        public int maxValue { get; set; }

        public SecondaryAttribute() { maxValue = 0; }

        //For secondary attr, this should set our default value. Example; Energy starts at 2/2.
        public SecondaryAttribute(string attrName, int value, int maxValue)
            : base(attrName, value) { this.maxValue = maxValue; }

    }

    public class BaseAttribute : Attribute
    {
        private int adjustVal;

        public BaseAttribute() { adjustVal = 0; }

        //This is for attributes with a base value. Example; Defense starts at a 10.
        public BaseAttribute(string attrName, int value, int adjustVal)
            : base(attrName, value) {this.adjustVal = adjustVal; }
    }
}
