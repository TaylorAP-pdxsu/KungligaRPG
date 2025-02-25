using KungligaRPG.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KungligaRPG.Interfaces
{
    //Port copying models for use by UI
    interface IUIModelUseCase
    {
        //Convert all attributes to strings
        public void CopyCharacterToStrings(Character inputModel);
        //Bind to UI
        public void BindToModel(ContentPage page);
    }
}
