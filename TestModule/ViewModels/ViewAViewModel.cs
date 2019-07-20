using Prism.Commands;
using Prism.Mvvm;
using SharedService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestModule.ViewModels
{
    public class ViewAViewModel : BindableBase
    {
        private string _message;
        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

        public ViewAViewModel(Services service)
        {
            Message = $"Taqeh Service State {service.Taqeh.State}";
            
        }
    }
}
