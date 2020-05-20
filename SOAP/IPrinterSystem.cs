﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SOAP
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IPrinterSystem" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IPrinterSystem
    {
        [OperationContract]
        double Add(double a, double b);
    }
}
