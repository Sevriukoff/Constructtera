using System.Collections.ObjectModel;
using TerrariaConstructor.Models;
using TerrariaConstructor.ViewModels.Base;

namespace TerrariaConstructor.ViewModels;

public class VoidInventoryViewModel : BaseInventoryViewModel
{
    public VoidInventoryViewModel(InventoriesModel model) : base(model)
    {
        Items = new ObservableCollection<Item>(model.Bank4);
    }
}