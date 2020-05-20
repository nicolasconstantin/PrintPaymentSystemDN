using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SOAP
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "PrinterSystem" à la fois dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez PrinterSystem.svc ou PrinterSystem.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class PrinterSystem : IPrinterSystem
    {
        public double Add(double a, double b)
        {
            return a + b;
        }
    }
}
