﻿namespace Artworks.Configuration.CommonModel
{
    /// <summary>
    /// 配置异常。
    /// </summary>
    public class ConfigurationException : ArtworksException
    {
        #region Ctor
        /// <summary>
        /// Initializes a new instance of the <c>ConfigurationException</c> class.
        /// </summary>
        public ConfigurationException() : base() { }
        /// <summary>
        /// Initializes a new instance of the <c>ConfigurationException</c> class with the specified
        /// error message.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public ConfigurationException(string message) : base(message) { }
        /// <summary>
        /// Initializes a new instance of the <c>ConfigurationException</c> class with the specified
        /// error message and the inner exception that is the cause of this exception.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        /// <param name="innerException">The inner exception that is the cause of this exception.</param>
        public ConfigurationException(string message, System.Exception innerException) : base(message, innerException) { }
        /// <summary>
        /// Initializes a new instance of the <c>ConfigurationException</c> class with the specified
        /// string formatter and the arguments that are used for formatting the message which
        /// describes the error.
        /// </summary>
        /// <param name="format">The string formatter which is used for formatting the error message.</param>
        /// <param name="args">The arguments that are used by the formatter to build the error message.</param>
        public ConfigurationException(string format, params object[] args) : base(string.Format(format, args)) { }

        #endregion
    }
}
