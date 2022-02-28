using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutofacDemo1
{
    public class EmailService : IMailService
    {
        public void Execute()
        {
            Console.WriteLine("Email Service");
        }
    }
}
