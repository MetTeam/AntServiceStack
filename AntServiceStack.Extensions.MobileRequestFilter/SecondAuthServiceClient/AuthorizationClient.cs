﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1026
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AntServiceStack.Extensions.MobileRequestFilter.SecondAuthServiceClient
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
    using System.Threading;
    using System.Threading.Tasks;
    using AntServiceStack.ServiceClient;
    using AntServiceStack.Common.Types;
    
    
    /// <summary>
    /// 登陆类型
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1026")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://soa.ant.com/platform/account/authorization/v1")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://soa.ant.com/platform/account/authorization/v1", IsNullable=false)]
    [DataContract(Namespace="http://soa.ant.com/platform/account/authorization/v1")]
    [ProtoContract()]
    public enum LoginType
    {
        
        /// <summary>
        /// 普通登录
        /// </summary>
        [EnumMember()]
        [ProtoEnum()]
        MemberLogin,
        
        /// <summary>
        /// 第三方登录
        /// </summary>
        [EnumMember()]
        [ProtoEnum()]
        ThirdPart,
        
        /// <summary>
        /// 联合登录
        /// </summary>
        [EnumMember()]
        [ProtoEnum()]
        Union,
        
        /// <summary>
        /// 合作卡登录
        /// </summary>
        [EnumMember()]
        [ProtoEnum()]
        Card,
        
        /// <summary>
        /// 临时用户登录
        /// </summary>
        [EnumMember()]
        [ProtoEnum()]
        TempUser,
        
        /// <summary>
        /// 动态密码登录
        /// </summary>
        [EnumMember()]
        [ProtoEnum()]
        DynamicPwd,
        
        /// <summary>
        /// 其他
        /// </summary>
        [EnumMember()]
        [ProtoEnum()]
        Other,
        
        /// <summary>
        /// 查单用户登录
        /// </summary>
        [EnumMember()]
        [ProtoEnum()]
        GetOrder,
    }
    
    /// <summary>
    /// KeyValue字符串
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1026")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://soa.ant.com/platform/account/authorization/v1")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://soa.ant.com/platform/account/authorization/v1", IsNullable=false)]
    [DataContract(Namespace="http://soa.ant.com/platform/account/authorization/v1")]
    [ProtoContract()]
    public partial class KeyValueString
    {
        
        private string keyField;
        
        private string valueField;
        
        /// <summary>
        /// Key
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public string Key
        {
            get
            {
                return this.keyField;
            }
            set
            {
                this.keyField = value;
            }
        }
        
        /// <summary>
        /// Value
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }
    
    /// <summary>
    /// 验证Ticket状态请求
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1026")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://soa.ant.com/platform/account/authorization/v1")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://soa.ant.com/platform/account/authorization/v1", IsNullable=false)]
    [DataContract(Namespace="http://soa.ant.com/platform/account/authorization/v1")]
    [ProtoContract()]
    public partial class ValidateTicketRequest
    {
        
        private string ticketField;
        
        private MobileRequestHead headField;
        
        /// <summary>
        /// Ticket
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public string Ticket
        {
            get
            {
                return this.ticketField;
            }
            set
            {
                this.ticketField = value;
            }
        }
        
        [DataMember()]
        [ProtoMember(2)]
        public MobileRequestHead head
        {
            get
            {
                return this.headField;
            }
            set
            {
                this.headField = value;
            }
        }
    }
    
    /// <summary>
    /// 验证Ticket状态响应
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1026")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://soa.ant.com/platform/account/authorization/v1")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://soa.ant.com/platform/account/authorization/v1", IsNullable=false)]
    [DataContract(Namespace="http://soa.ant.com/platform/account/authorization/v1")]
    [ProtoContract()]
    public partial class ValidateTicketResponse
    {
        
        private string uIDField;
        
        private string loginNameField;
        
        private LoginType loginTypeField;
        
        private int returnCodeField;
        
        private string messageField;
        
        private ResponseStatusType responseStatusField;
        
        /// <summary>
        /// UID
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public string UID
        {
            get
            {
                return this.uIDField;
            }
            set
            {
                this.uIDField = value;
            }
        }
        
        /// <summary>
        /// 登录名
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public string LoginName
        {
            get
            {
                return this.loginNameField;
            }
            set
            {
                this.loginNameField = value;
            }
        }
        
        /// <summary>
        /// 登录类型
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public LoginType LoginType
        {
            get
            {
                return this.loginTypeField;
            }
            set
            {
                this.loginTypeField = value;
            }
        }
        
        /// <summary>
        /// 返回码
        /// 0:成功
        /// 101:Ticket为空
        /// 201:Ticket无效
        /// 202:Ticket已被强制下线
        /// 900:内部异常
        /// </summary>
        [DataMember()]
        [ProtoMember(4)]
        public int ReturnCode
        {
            get
            {
                return this.returnCodeField;
            }
            set
            {
                this.returnCodeField = value;
            }
        }
        
        /// <summary>
        /// 返回消息
        /// </summary>
        [DataMember()]
        [ProtoMember(5)]
        public string Message
        {
            get
            {
                return this.messageField;
            }
            set
            {
                this.messageField = value;
            }
        }
        
        [DataMember()]
        [ProtoMember(6)]
        public ResponseStatusType ResponseStatus
        {
            get
            {
                return this.responseStatusField;
            }
            set
            {
                this.responseStatusField = value;
            }
        }
    }
    
    /// <summary>
    /// 获取会话信息
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1026")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://soa.ant.com/platform/account/authorization/v1")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://soa.ant.com/platform/account/authorization/v1", IsNullable=false)]
    [DataContract(Namespace="http://soa.ant.com/platform/account/authorization/v1")]
    [ProtoContract()]
    public partial class GetLoginSessionByTicketRequest
    {
        
        private string ticketField;
        
        private MobileRequestHead headField;
        
        /// <summary>
        /// Ticket
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public string Ticket
        {
            get
            {
                return this.ticketField;
            }
            set
            {
                this.ticketField = value;
            }
        }
        
        [DataMember()]
        [ProtoMember(2)]
        public MobileRequestHead head
        {
            get
            {
                return this.headField;
            }
            set
            {
                this.headField = value;
            }
        }
    }
    
    /// <summary>
    /// 获取会话信息
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1026")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://soa.ant.com/platform/account/authorization/v1")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://soa.ant.com/platform/account/authorization/v1", IsNullable=false)]
    [DataContract(Namespace="http://soa.ant.com/platform/account/authorization/v1")]
    [ProtoContract()]
    public partial class GetLoginSessionByTicketResponse
    {
        
        private int returnCodeField;
        
        private string messageField;
        
        private string uIDField;
        
        private string loginNameField;
        
        private string loginTypeField;
        
        private string loginEntranceField;
        
        private string loginWayField;
        
        private System.DateTime loginTimeField;
        
        private System.DateTime expirationField;
        
        private string clientIPField;
        
        private bool isAutoLoginField;
        
        private List<KeyValueString> sessionInfoField;
        
        private ResponseStatusType responseStatusField;
        
        /// <summary>
        /// 返回码
        /// 0:成功
        /// 101:Ticket为空
        /// 201:Ticket无效
        /// 202:Ticket已被强制下线
        /// 900:内部异常
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int ReturnCode
        {
            get
            {
                return this.returnCodeField;
            }
            set
            {
                this.returnCodeField = value;
            }
        }
        
        /// <summary>
        /// 返回消息
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public string Message
        {
            get
            {
                return this.messageField;
            }
            set
            {
                this.messageField = value;
            }
        }
        
        /// <summary>
        /// UID
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public string UID
        {
            get
            {
                return this.uIDField;
            }
            set
            {
                this.uIDField = value;
            }
        }
        
        /// <summary>
        /// 登录名
        /// </summary>
        [DataMember()]
        [ProtoMember(4)]
        public string LoginName
        {
            get
            {
                return this.loginNameField;
            }
            set
            {
                this.loginNameField = value;
            }
        }
        
        /// <summary>
        /// 登录类型
        /// </summary>
        [DataMember()]
        [ProtoMember(5)]
        public string LoginType
        {
            get
            {
                return this.loginTypeField;
            }
            set
            {
                this.loginTypeField = value;
            }
        }
        
        /// <summary>
        /// 登录入口
        /// </summary>
        [DataMember()]
        [ProtoMember(6)]
        public string LoginEntrance
        {
            get
            {
                return this.loginEntranceField;
            }
            set
            {
                this.loginEntranceField = value;
            }
        }
        
        /// <summary>
        /// 登录站点
        /// </summary>
        [DataMember()]
        [ProtoMember(7)]
        public string LoginWay
        {
            get
            {
                return this.loginWayField;
            }
            set
            {
                this.loginWayField = value;
            }
        }
        
        /// <summary>
        /// 登录时间
        /// </summary>
        [DataMember()]
        [ProtoMember(8)]
        public System.DateTime LoginTime
        {
            get
            {
                return this.loginTimeField;
            }
            set
            {
                this.loginTimeField = value;
            }
        }
        
        /// <summary>
        /// 过期时间
        /// </summary>
        [DataMember()]
        [ProtoMember(9)]
        public System.DateTime Expiration
        {
            get
            {
                return this.expirationField;
            }
            set
            {
                this.expirationField = value;
            }
        }
        
        /// <summary>
        /// 登录IP
        /// </summary>
        [DataMember()]
        [ProtoMember(10)]
        public string ClientIP
        {
            get
            {
                return this.clientIPField;
            }
            set
            {
                this.clientIPField = value;
            }
        }
        
        /// <summary>
        /// 是否自动登录
        /// </summary>
        [DataMember()]
        [ProtoMember(11)]
        public bool IsAutoLogin
        {
            get
            {
                return this.isAutoLoginField;
            }
            set
            {
                this.isAutoLoginField = value;
            }
        }
        
        /// <summary>
        /// 扩展会话信息
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("SessionInfo")]
        [DataMember()]
        [ProtoMember(12)]
        public List<KeyValueString> SessionInfo
        {
            get
            {
                if ((this.sessionInfoField == null))
                {
                    this.sessionInfoField = new List<KeyValueString>();
                }
                return this.sessionInfoField;
            }
            set
            {
                this.sessionInfoField = value;
            }
        }
        
        [DataMember()]
        [ProtoMember(13)]
        public ResponseStatusType ResponseStatus
        {
            get
            {
                return this.responseStatusField;
            }
            set
            {
                this.responseStatusField = value;
            }
        }
    }
    
    /// <summary>
    /// 二级授权场景
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1026")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://soa.ant.com/platform/account/authorization/v1")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://soa.ant.com/platform/account/authorization/v1", IsNullable=false)]
    [DataContract(Namespace="http://soa.ant.com/platform/account/authorization/v1")]
    [ProtoContract()]
    public enum SecondTokenSceneType
    {
        
        /// <summary>
        /// 站内信
        /// </summary>
        [EnumMember()]
        [ProtoEnum()]
        InternalMessage,
        
        /// <summary>
        /// 第三方会员信息
        /// </summary>
        [EnumMember()]
        [ProtoEnum()]
        ThirdPartInfo,
        
        /// <summary>
        /// 其他
        /// </summary>
        [EnumMember()]
        [ProtoEnum()]
        Other,
    }
    
    /// <summary>
    /// 创建二级授权token请求
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1026")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://soa.ant.com/platform/account/authorization/v1")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://soa.ant.com/platform/account/authorization/v1", IsNullable=false)]
    [DataContract(Namespace="http://soa.ant.com/platform/account/authorization/v1")]
    [ProtoContract()]
    public partial class GenSecondAuthorizationTokenRequest : IHasMobileRequestHead
    {
        
        private SecondTokenSceneType sceneTypeField;
        
        private string authField;
        
        private MobileRequestHead headField;
        
        /// <summary>
        /// 验证场景
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public SecondTokenSceneType SceneType
        {
            get
            {
                return this.sceneTypeField;
            }
            set
            {
                this.sceneTypeField = value;
            }
        }
        
        /// <summary>
        /// Auth
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public string Auth
        {
            get
            {
                return this.authField;
            }
            set
            {
                this.authField = value;
            }
        }
        
        [DataMember()]
        [ProtoMember(3)]
        public MobileRequestHead head
        {
            get
            {
                return this.headField;
            }
            set
            {
                this.headField = value;
            }
        }
    }
    
    /// <summary>
    /// 创建二级授权token响应
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1026")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://soa.ant.com/platform/account/authorization/v1")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://soa.ant.com/platform/account/authorization/v1", IsNullable=false)]
    [DataContract(Namespace="http://soa.ant.com/platform/account/authorization/v1")]
    [ProtoContract()]
    public partial class GenSecondAuthorizationTokenResponse : IHasResponseStatus
    {
        
        private string tokenField;
        
        private string uidField;
        
        private string expiredTimeField;
        
        private int returnCodeField;
        
        private string messageField;
        
        private ResponseStatusType responseStatusField;
        
        /// <summary>
        /// Token
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public string Token
        {
            get
            {
                return this.tokenField;
            }
            set
            {
                this.tokenField = value;
            }
        }
        
        /// <summary>
        /// UID
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public string Uid
        {
            get
            {
                return this.uidField;
            }
            set
            {
                this.uidField = value;
            }
        }
        
        /// <summary>
        /// 过期时间
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public string ExpiredTime
        {
            get
            {
                return this.expiredTimeField;
            }
            set
            {
                this.expiredTimeField = value;
            }
        }
        
        /// <summary>
        /// 返回码
        /// 0:成功
        /// 101:Ticket为空
        /// 201:Ticket无效
        /// 202:Ticket已被强制下线
        /// 900:内部异常
        /// </summary>
        [DataMember()]
        [ProtoMember(4)]
        public int ReturnCode
        {
            get
            {
                return this.returnCodeField;
            }
            set
            {
                this.returnCodeField = value;
            }
        }
        
        /// <summary>
        /// 返回消息
        /// </summary>
        [DataMember()]
        [ProtoMember(5)]
        public string Message
        {
            get
            {
                return this.messageField;
            }
            set
            {
                this.messageField = value;
            }
        }
        
        [DataMember()]
        [ProtoMember(6)]
        public ResponseStatusType ResponseStatus
        {
            get
            {
                return this.responseStatusField;
            }
            set
            {
                this.responseStatusField = value;
            }
        }
    }
    
    /// <summary>
    /// 验证二级授权请求
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1026")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://soa.ant.com/platform/account/authorization/v1")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://soa.ant.com/platform/account/authorization/v1", IsNullable=false)]
    [DataContract(Namespace="http://soa.ant.com/platform/account/authorization/v1")]
    [ProtoContract()]
    public partial class CheckSecondTokenRequest : IHasMobileRequestHead
    {
        
        private string tokenField;
        
        private string authField;
        
        private MobileRequestHead headField;
        
        /// <summary>
        /// 验证token
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public string Token
        {
            get
            {
                return this.tokenField;
            }
            set
            {
                this.tokenField = value;
            }
        }
        
        /// <summary>
        /// 一级auth
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public string Auth
        {
            get
            {
                return this.authField;
            }
            set
            {
                this.authField = value;
            }
        }
        
        [DataMember()]
        [ProtoMember(3)]
        public MobileRequestHead head
        {
            get
            {
                return this.headField;
            }
            set
            {
                this.headField = value;
            }
        }
    }
    
    /// <summary>
    /// 验证二级授权响应
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1026")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://soa.ant.com/platform/account/authorization/v1")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://soa.ant.com/platform/account/authorization/v1", IsNullable=false)]
    [DataContract(Namespace="http://soa.ant.com/platform/account/authorization/v1")]
    [ProtoContract()]
    public partial class CheckSecondTokenResponse : IHasResponseStatus
    {
        
        private string uidField;
        
        private int returnCodeField;
        
        private string messageField;
        
        private bool isNewField;
        
        private string tokenField;
        
        private ResponseStatusType responseStatusField;
        
        /// <summary>
        /// UID
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public string Uid
        {
            get
            {
                return this.uidField;
            }
            set
            {
                this.uidField = value;
            }
        }
        
        /// <summary>
        /// 返回码
        /// 0:成功
        /// 101:Token为空
        /// 102：auth为空
        /// 201:验证失败
        /// 900:内部异常
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public int ReturnCode
        {
            get
            {
                return this.returnCodeField;
            }
            set
            {
                this.returnCodeField = value;
            }
        }
        
        /// <summary>
        /// 返回消息
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public string Message
        {
            get
            {
                return this.messageField;
            }
            set
            {
                this.messageField = value;
            }
        }
        
        /// <summary>
        /// Token是否新生成
        /// </summary>
        [DataMember()]
        [ProtoMember(4)]
        public bool IsNew
        {
            get
            {
                return this.isNewField;
            }
            set
            {
                this.isNewField = value;
            }
        }
        
        /// <summary>
        /// Token
        /// </summary>
        [DataMember()]
        [ProtoMember(5)]
        public string Token
        {
            get
            {
                return this.tokenField;
            }
            set
            {
                this.tokenField = value;
            }
        }
        
        [DataMember()]
        [ProtoMember(6)]
        public ResponseStatusType ResponseStatus
        {
            get
            {
                return this.responseStatusField;
            }
            set
            {
                this.responseStatusField = value;
            }
        }
    }
    
    /// <summary>
    /// Service client auto-generated by SOA tool, DO NOT CHANGE!
    /// 
    /// 
    /// </summary>
    public class AuthorizationClient : ServiceClientBase<AuthorizationClient>
    {
        
        public const string CodeGeneratorVersion = "2.0.7.1";
        
        public const string OriginalServiceName = "Authorization";
        
        public const string OriginalServiceNamespace = "http://soa.ant.com/platform/account/authorization/v1";
        
        public const string OriginalServiceType = "NonSLB";
        
        private AuthorizationClient(string baseUri) : 
                base(baseUri)
        {
        }
        
        private AuthorizationClient(string serviceName, string serviceNamespace, string subEnv) : 
                base(serviceName, serviceNamespace, subEnv)
        {
        }
        
        public virtual CheckHealthResponseType CheckHealth(CheckHealthRequestType checkHealthIn)
        {
            return base.Invoke<CheckHealthResponseType>("CheckHealth", checkHealthIn);
        }
        
        public virtual Task<CheckHealthResponseType> CreateAsyncTaskOfCheckHealth(CheckHealthRequestType checkHealthIn, CancellationToken? cancellationToken = null, TaskCreationOptions? taskCreationOptions = null)
        {
            return base.CreateAsyncTask<CheckHealthRequestType, CheckHealthResponseType>("CheckHealth", checkHealthIn, cancellationToken, taskCreationOptions);
        }
        
        public virtual Task<CheckHealthResponseType> StartIOCPTaskOfCheckHealth(CheckHealthRequestType checkHealthIn)
        {
            return base.StartIOCPTask<CheckHealthResponseType>("CheckHealth", checkHealthIn);
        }
        
        public virtual CheckSecondTokenResponse CheckSecondToken(CheckSecondTokenRequest checkSecondTokenIn)
        {
            return base.Invoke<CheckSecondTokenResponse>("CheckSecondToken", checkSecondTokenIn);
        }
        
        public virtual Task<CheckSecondTokenResponse> CreateAsyncTaskOfCheckSecondToken(CheckSecondTokenRequest checkSecondTokenIn, CancellationToken? cancellationToken = null, TaskCreationOptions? taskCreationOptions = null)
        {
            return base.CreateAsyncTask<CheckSecondTokenRequest, CheckSecondTokenResponse>("CheckSecondToken", checkSecondTokenIn, cancellationToken, taskCreationOptions);
        }
        
        public virtual Task<CheckSecondTokenResponse> StartIOCPTaskOfCheckSecondToken(CheckSecondTokenRequest checkSecondTokenIn)
        {
            return base.StartIOCPTask<CheckSecondTokenResponse>("CheckSecondToken", checkSecondTokenIn);
        }
        
        public virtual GenSecondAuthorizationTokenResponse GenSecondAuthorizationToken(GenSecondAuthorizationTokenRequest genSecondAuthorizationTokenIn)
        {
            return base.Invoke<GenSecondAuthorizationTokenResponse>("GenSecondAuthorizationToken", genSecondAuthorizationTokenIn);
        }
        
        public virtual Task<GenSecondAuthorizationTokenResponse> CreateAsyncTaskOfGenSecondAuthorizationToken(GenSecondAuthorizationTokenRequest genSecondAuthorizationTokenIn, CancellationToken? cancellationToken = null, TaskCreationOptions? taskCreationOptions = null)
        {
            return base.CreateAsyncTask<GenSecondAuthorizationTokenRequest, GenSecondAuthorizationTokenResponse>("GenSecondAuthorizationToken", genSecondAuthorizationTokenIn, cancellationToken, taskCreationOptions);
        }
        
        public virtual Task<GenSecondAuthorizationTokenResponse> StartIOCPTaskOfGenSecondAuthorizationToken(GenSecondAuthorizationTokenRequest genSecondAuthorizationTokenIn)
        {
            return base.StartIOCPTask<GenSecondAuthorizationTokenResponse>("GenSecondAuthorizationToken", genSecondAuthorizationTokenIn);
        }
    }
}
