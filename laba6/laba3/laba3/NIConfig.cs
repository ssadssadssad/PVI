using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace laba3
{
    public class NIConfig : NinjectModule

    {
        public override void Load()
        {
            Bind<TelephoneDictionaryDLL.IPhoneDictionary>().To<TelephoneDictionaryDLL.DB>();
            //Bind<SQLTelephoneDictionary.IPhoneDictionary>().To<SQLTelephoneDictionary.DB>();

            // InTransientScope() - по умолчанию - новый на каждый вызов
            // InSingletonScope() - паттерн Singleton - один на все вызовы
            // InThreadScope() - новый экземпляр на каждый поток
            // InRequestScope() - новый экземпляр на каждый запрос
        }
    }
}