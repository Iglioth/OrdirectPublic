using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrdirectWebsite
{
    public interface IViewModelConverterContext
    {
        object ModelToViewModel(object o);

        object ViewModelToModel(object o);
    }
}
