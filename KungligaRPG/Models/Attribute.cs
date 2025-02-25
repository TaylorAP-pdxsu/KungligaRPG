using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace KungligaRPG.Models
{
    public abstract class Attribute
    {
        public string attrName {  get; set; }
        public abstract dynamic currValue { get; set; }
        public dynamic topValue { get; set; }

        protected Attribute() { attrName = ""; currValue = ""; topValue = ""; }
        public Attribute(string attrName) { this.attrName = attrName; currValue = ""; topValue = ""; }

        public abstract (string, string?) GetTuple();
    }

    //topValue represents a value cap, which you cannot go above
    public class PrimaryAttribute : Attribute
    {
        public override dynamic currValue { get; set; } = new int();
        public new dynamic topValue { get; set; } = new int();

        public PrimaryAttribute() { }
        
        public PrimaryAttribute(string attrName, int currValue, int topValue)
                                : base(attrName) { this.currValue = currValue;  this.topValue = topValue; }

        public override (string, string) GetTuple()
        {
            return (currValue.ToString(), topValue.ToString());
        }
    }

    //topValue represents a max value your attr resets to, curr value could be above max.
    //max value could also be increased.
    public class SecondaryAttribute : Attribute
    {
        public override dynamic currValue { get; set; } = new int();
        public new dynamic topValue { get; set; } = new int();

        public SecondaryAttribute() { currValue = 0; }

        public SecondaryAttribute(string attrName, int value, int maxValue)
            : base(attrName) { this.currValue = value; this.topValue = maxValue; }

        public override (string, string) GetTuple()
        {
            return (currValue.ToString(), topValue.ToString());
        }
    }

    //topValue represents an adjustment to the base attr.
    public class BaseAttribute : Attribute
    {
        public override dynamic currValue { get; set; } = new int();
        public new dynamic topValue { get; set; } = new int();

        public BaseAttribute() { currValue = 0; }

        public BaseAttribute(string attrName, int value, int adjustVal)
            : base(attrName) { this.currValue = value; this.topValue = adjustVal; }

        public override (string, string) GetTuple()
        {
            return (currValue.ToString(), topValue.ToString());
        }
    }

    //topValue is an unused value
    public class TextAttribute : Attribute
    {
        public override dynamic currValue { get; set; } = new string("");
        public new dynamic? topValue { get; set; } = null;

        public TextAttribute() { currValue = "New Character"; }

        public TextAttribute(string attrName, string value)
            : base(attrName) { this.currValue = value; }

        public override (string, string?) GetTuple()
        {
            return (currValue, topValue);
        }
    }
}
