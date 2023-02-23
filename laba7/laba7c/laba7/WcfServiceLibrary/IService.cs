using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfServiceLibrary.Models;

namespace WcfServiceLibrary
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени интерфейса "IService1" в коде и файле конфигурации.
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        List<Person> GetDict();
        [OperationContract]
        void AddDict(Person person);
        [OperationContract]
        void UpdDict(Person person);
        [OperationContract]
        void DelDict(Person person);
    }
}
