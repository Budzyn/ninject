using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ninject;

namespace DI_IoC
{
    class Ioc
    {
        private static Lazy<IKernel> mykernel = new Lazy<IKernel>(() => new StandardKernel());

        private static IKernel Kernel
        {
            get { return mykernel.Value; }
        }
        public static object Get(Type objectType)
        {
            return Kernel.Get(objectType);
        }

        public static T Get<T>()
        {
            return Kernel.Get<T>();
        }

        public static void Init(Action<IKernel> initLogic)
        {
            if (initLogic != null)
            {
                initLogic(Kernel);
            }
        }

        public static void Reset()
        {
            mykernel = new Lazy<IKernel>(() => new StandardKernel());
        }
    }
}
