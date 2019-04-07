using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace NetLabs.ViewModels
{
    public interface IForm
    {
        void Add();
        void Edit();
        void Delete();
        ICommand AddCommand { get; }
        ICommand EditCommand { get;  }
        ICommand DeleteCommand { get; }
    }
}
