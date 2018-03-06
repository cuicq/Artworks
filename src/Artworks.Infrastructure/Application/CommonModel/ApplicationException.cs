﻿using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Artworks.Application.CommonModel
{
    /// <summary>
    /// 应用程序异常基类。
    /// </summary>
    [Serializable]
    [ComVisible(true)]
    [ClassInterface(ClassInterfaceType.None)]
    [ComDefaultInterface(typeof(_Exception))]
    public class ApplicationException : System.Exception
    {

        #region Ctor
        /// <summary>
        /// Initializes a new instance of the <c>InfrastructureException</c> class.
        /// </summary>
        public ApplicationException() : base() { }
        /// <summary>
        /// Initializes a new instance of the <c>InfrastructureException</c> class with the specified
        /// error message.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public ApplicationException(string message) : base(message) { }
        /// <summary>
        /// Initializes a new instance of the <c>InfrastructureException</c> class with the specified
        /// error message and the inner exception that is the cause of this exception.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        /// <param name="innerException">The inner exception that is the cause of this exception.</param>
        public ApplicationException(string message, System.Exception innerException) : base(message, innerException) { }
        /// <summary>
        /// Initializes a new instance of the <c>InfrastructureException</c> class with the specified
        /// string formatter and the arguments that are used for formatting the message which
        /// describes the error.
        /// </summary>
        /// <param name="format">The string formatter which is used for formatting the error message.</param>
        /// <param name="args">The arguments that are used by the formatter to build the error message.</param>
        public ApplicationException(string format, params object[] args) : base(string.Format(format, args)) { }

        /// <summary>
        /// Initializes a new instance of <c>InfrastructureException</c> class.
        /// </summary>
        /// <param name="info">The System.Runtime.Serialization.SerializationInfo that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The System.Runtime.Serialization.StreamingContext that contains contextual information about the source or destination.</param>
        protected ApplicationException(SerializationInfo info, StreamingContext context) : base(info, context) { }

        #endregion

    }
}
