using Ninject.Modules;
using Ninject.Web.Common;
using Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lab3_mvc.injection
{
    public class NIConfig : NinjectModule
    {
        public override void Load()
        {
            //InTransientScope - по умолчанию, создается на каждое внедрение
            //Bind<IPhoneDictionary<DictRecord>>().To<DB>().InTransientScope();

            //  InThreadScope - один объект на один поток
            //Bind<IPhoneDictionary<DictRecord>>().To<DB>().InThreadScope();            

            //  InRequestScope - для одного HTTP один объект
            Bind<IPhoneDictionary<DictRecord>>().To<DB>().InRequestScope();            

            //Bind<IElementsDictionary<Telephone>>().To<TelephoneStorageEF>().InRequestScope();
            //  InRequestScope - для одного HTTP один объект
        }
    }
}