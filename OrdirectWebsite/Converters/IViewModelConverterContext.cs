using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrdirectWebsite
{
    public interface IViewModelConverterContext<TModel, TViewModel>
    {
        TViewModel ModelToDetailViewModel(TModel m);

        TModel DetailViewModelToModel(TViewModel vm);

        List<TModel> ViewModelToModels(List<TViewModel> vms);

        List<TViewModel> ModelsToViewModel(List<TModel> ms);
    }
}
