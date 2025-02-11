using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KungligaRPG.Models
{
    internal class characterBinding
    {
        Dictionary<string, Binding> attrBindings;

        public characterBinding()
        { 
            attrBindings = new Dictionary<string, Binding>();
        }

        //**NOTE: consider more generic type than label if possible
        public void CreateBinding(Attribute toBind, string source, string path, Label xamlView)
        {
            Binding newBind = new Binding();
            newBind.Source = source;
            newBind.Path = path;
            xamlView.SetBinding(Label.TextProperty, newBind);
            attrBindings.Add(toBind.attrName, newBind);
        }
    }
}
