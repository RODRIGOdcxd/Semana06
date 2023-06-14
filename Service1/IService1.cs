using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Service1
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        CustomerData Get();

        [OperationContract]
        void Insert(string name, string country);

        [OperationContract]
        void Update(int customerId, string name, string country);

        [OperationContract]
        void Delete(int customerId);
    }
}
