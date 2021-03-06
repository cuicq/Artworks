﻿using System;
using System.Reflection.Emit;

namespace Artworks.Container.Interceptors.TypeInterceptors.VirtualMethodInterception {
    /// <summary>
    /// 
    /// </summary>
    public partial class InterceptingClassGenerator {

        private static ModuleBuilder GetModuleBuilder() {
            string moduleName = Guid.NewGuid().ToString("N");
#if DEBUG_SAVE_GENERATED_ASSEMBLY
            return assemblyBuilder.DefineDynamicModule(moduleName, moduleName + ".dll", true);
#else
            return assemblyBuilder.DefineDynamicModule(moduleName);
#endif
        }

    }
}
