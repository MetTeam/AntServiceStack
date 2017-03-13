﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1026
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AntServiceStack.Common.Types
{
    using System;
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System.Collections;
    using System.Xml.Schema;
    using System.ComponentModel;
    using System.Runtime.Serialization;
    using System.Collections.Generic;
    using AntServiceStack.ProtoBuf;
    using AntServiceStack.ServiceHost;
    using AntServiceStack.Baiji.Specific;
    using System.Linq;
    
    
    /// <summary>
    /// AckCodeType - Type declaration to be used by other schema. This code identifies
    /// the acknowledgement code types that ANT could use to communicate the status of
    /// processing a (request) message to a client. This code would be used as part
    /// of a response message that contains a framework, validation or service-level
    /// acknowledgement element.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1026")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://soa.ant.com/common/types/v1")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace= "http://soa.ant.com/common/types/v1", IsNullable=false)]
    [DataContract(Namespace= "http://soa.ant.com/common/types/v1")]
    [ProtoContract()]
    public enum AckCodeType
    {
        
        /// <summary>
        /// (out) Request processing succeeded
        /// </summary>
        [EnumMember()]
        [ProtoEnum()]
        Success,
        
        /// <summary>
        /// (out) Request processing failed
        /// </summary>
        [EnumMember()]
        [ProtoEnum()]
        Failure,
        
        /// <summary>
        /// (out) Request processing completed with warning information
        /// being included in the response message
        /// </summary>
        [EnumMember()]
        [ProtoEnum()]
        Warning,
        
        /// <summary>
        /// (out) Request processing completed with some failures.
        /// See the Errors data to determine which portions of the request failed.
        /// </summary>
        [EnumMember()]
        [ProtoEnum()]
        PartialFailure,
    }
}