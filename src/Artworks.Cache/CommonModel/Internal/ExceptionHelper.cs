﻿using Artworks.Anomaly;
using System;

namespace Artworks.Cache.CommonModel.Internal
{
    /// <summary>
    /// 异常处理帮助。
    /// </summary>
    internal class ExceptionHelper
    {
        /// <summary>
        /// 异常处理
        /// </summary>
        public static bool HandleException(Exception ex)
        {
            var innerException = new CacheException(ex.Message, ex);
            return ExceptionManager.HandleException(innerException);
        }

    }
}
