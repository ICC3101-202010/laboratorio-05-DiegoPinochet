using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pinochet_Diego_Lab5POO
{
    public class User
    {
        public void OnEmailSent(object source, EventArgs empty)
        {
            Console.WriteLine("Correo de verificación ha sido enviado");
            Console.WriteLine("¿Quiere verificar su correo? (Si/No)");
            string sino = Console.ReadLine();
            if (sino == "Si")
            {
                OnEmailVerified();
            }
            
        }

        public delegate void EmailVerifyEvetHandler(object source, EventArgs empty);
        public event EmailVerifyEvetHandler EmailVerified;

        protected virtual void OnEmailVerified()
        {
            if(EmailVerified != null)
            {
                EmailVerified(this, new EventArgs());
                
            }
        }
    }
}

