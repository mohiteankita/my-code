using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutofacDemo1
{
    class NotificationSender
    {
        public IMobileService _mobileService = null;
        public IMailService _mailService = null;

        //Injection Through Constructor
        public NotificationSender(IMobileService tmpService)
        {
            _mobileService = tmpService;
        }

        //Injection Through Property
        public IMailService SetMailService
        {
            set
            {
                _mailService = value;
            }
        }

        public void SendNotification()
        {
            _mobileService.Execute();
            _mailService.Execute();
        }
    }
}
