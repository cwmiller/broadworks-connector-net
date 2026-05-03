using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to modify Outbound Proxy Cache system parameters.
    /// The response is either SuccessResponse or ErrorResponse.
    /// 
    /// Note that an error is returned if CloudPBX is not licensed.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:14437""}]")]
    public class SystemOutboundProxyCacheParametersModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected int? _evictionTimeoutMinutes;

        [XmlElement(ElementName = "evictionTimeoutMinutes", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:14437")]
        [MinInclusive(0)]
        [MaxInclusive(525600)]
        public int? EvictionTimeoutMinutes
        {
            get => _evictionTimeoutMinutes;
            set
            {
                EvictionTimeoutMinutesSpecified = (value != null);
                _evictionTimeoutMinutes = value;
            }
        }

        [XmlIgnore]
        protected bool EvictionTimeoutMinutesSpecified { get; set; }

        protected int? _refreshTimeoutMinutes;

        [XmlElement(ElementName = "refreshTimeoutMinutes", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:14437")]
        [MinInclusive(0)]
        [MaxInclusive(525600)]
        public int? RefreshTimeoutMinutes
        {
            get => _refreshTimeoutMinutes;
            set
            {
                RefreshTimeoutMinutesSpecified = (value != null);
                _refreshTimeoutMinutes = value;
            }
        }

        [XmlIgnore]
        protected bool RefreshTimeoutMinutesSpecified { get; set; }

        protected int? _auditIntervalMinutes;

        [XmlElement(ElementName = "auditIntervalMinutes", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:14437")]
        [MinInclusive(0)]
        [MaxInclusive(525600)]
        public int? AuditIntervalMinutes
        {
            get => _auditIntervalMinutes;
            set
            {
                AuditIntervalMinutesSpecified = (value != null);
                _auditIntervalMinutes = value;
            }
        }

        [XmlIgnore]
        protected bool AuditIntervalMinutesSpecified { get; set; }

        protected int? _maximumCacheSize;

        [XmlElement(ElementName = "maximumCacheSize", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:14437")]
        [MinInclusive(0)]
        public int? MaximumCacheSize
        {
            get => _maximumCacheSize;
            set
            {
                MaximumCacheSizeSpecified = (value != null);
                _maximumCacheSize = value;
            }
        }

        [XmlIgnore]
        protected bool MaximumCacheSizeSpecified { get; set; }

        protected string _dnsTypeDefaultValue;

        /// <remarks>Eraseable</remarks>
        [XmlElement(ElementName = "dnsTypeDefaultValue", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:14437")]
        [MinLength(1)]
        [MaxLength(256)]
        public string DnsTypeDefaultValue
        {
            get => _dnsTypeDefaultValue;
            set
            {
                DnsTypeDefaultValueSpecified = true;
                _dnsTypeDefaultValue = value;
            }
        }

        [XmlIgnore]
        protected bool DnsTypeDefaultValueSpecified { get; set; }

        protected string _useDnsSrvDefaultValue;

        /// <remarks>Eraseable</remarks>
        [XmlElement(ElementName = "useDnsSrvDefaultValue", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:14437")]
        [MinLength(1)]
        [MaxLength(256)]
        public string UseDnsSrvDefaultValue
        {
            get => _useDnsSrvDefaultValue;
            set
            {
                UseDnsSrvDefaultValueSpecified = true;
                _useDnsSrvDefaultValue = value;
            }
        }

        [XmlIgnore]
        protected bool UseDnsSrvDefaultValueSpecified { get; set; }

        protected string _srvPrefixDefaultValue;

        /// <remarks>Eraseable</remarks>
        [XmlElement(ElementName = "srvPrefixDefaultValue", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:14437")]
        [MinLength(1)]
        [MaxLength(256)]
        public string SrvPrefixDefaultValue
        {
            get => _srvPrefixDefaultValue;
            set
            {
                SrvPrefixDefaultValueSpecified = true;
                _srvPrefixDefaultValue = value;
            }
        }

        [XmlIgnore]
        protected bool SrvPrefixDefaultValueSpecified { get; set; }

        protected string _outboundProxyDefaultValue;

        /// <remarks>Eraseable</remarks>
        [XmlElement(ElementName = "outboundProxyDefaultValue", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:14437")]
        [MinLength(1)]
        [MaxLength(256)]
        public string OutboundProxyDefaultValue
        {
            get => _outboundProxyDefaultValue;
            set
            {
                OutboundProxyDefaultValueSpecified = true;
                _outboundProxyDefaultValue = value;
            }
        }

        [XmlIgnore]
        protected bool OutboundProxyDefaultValueSpecified { get; set; }

        protected string _transportTypeDefaultValue;

        /// <remarks>Eraseable</remarks>
        [XmlElement(ElementName = "transportTypeDefaultValue", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:14437")]
        [MinLength(1)]
        [MaxLength(256)]
        public string TransportTypeDefaultValue
        {
            get => _transportTypeDefaultValue;
            set
            {
                TransportTypeDefaultValueSpecified = true;
                _transportTypeDefaultValue = value;
            }
        }

        [XmlIgnore]
        protected bool TransportTypeDefaultValueSpecified { get; set; }

        protected string _secureRtpDefaultValue;

        /// <remarks>Eraseable</remarks>
        [XmlElement(ElementName = "secureRtpDefaultValue", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:14437")]
        [MinLength(1)]
        [MaxLength(256)]
        public string SecureRtpDefaultValue
        {
            get => _secureRtpDefaultValue;
            set
            {
                SecureRtpDefaultValueSpecified = true;
                _secureRtpDefaultValue = value;
            }
        }

        [XmlIgnore]
        protected bool SecureRtpDefaultValueSpecified { get; set; }

    }
}
