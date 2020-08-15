using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gat.Controls
{
    public interface IOpenDialogFactory
    {
        IOpenDialogViewModel Get();
    }
    [Export(typeof(IOpenDialogFactory))]
    public class OpenDialogFactory : IOpenDialogFactory
    {
        public IOpenDialogViewModel Get()
        {
            var view = new OpenDialogView();
            return view.DataContext as IOpenDialogViewModel;
        }
    }
}
