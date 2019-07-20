using SharedService.TaqehService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace SharedService
{
    public class Services
    {
        public TaqehServiceClient Taqeh {
            get
            {
                return new TaqehServiceClient();
            }
            set
            {
                Taqeh = value;
            }
        }
    }
}
