using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemOutboundProxyCacheParametersGetRequest.
    /// Contains a list of Outbound Proxy Cache system parameters.
    /// <see cref="SystemOutboundProxyCacheParametersGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:14065""}]")]
    public class SystemOutboundProxyCacheParametersGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private int _evictionTimeoutMinutes;

        [XmlElement(ElementName = "evictionTimeoutMinutes", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:14065")]
        [MinInclusive(0)]
        [MaxInclusive(525600)]
        public int EvictionTimeoutMinutes
        {
            get => _evictionTimeoutMinutes;
            set
            {
                EvictionTimeoutMinutesSpecified = true;
                _evictionTimeoutMinutes = value;
            }
        }

        [XmlIgnore]
        protected bool EvictionTimeoutMinutesSpecified { get; set; }

        private int _refreshTimeoutMinutes;

        [XmlElement(ElementName = "refreshTimeoutMinutes", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:14065")]
        [MinInclusive(0)]
        [MaxInclusive(525600)]
        public int RefreshTimeoutMinutes
        {
            get => _refreshTimeoutMinutes;
            set
            {
                RefreshTimeoutMinutesSpecified = true;
                _refreshTimeoutMinutes = value;
            }
        }

        [XmlIgnore]
        protected bool RefreshTimeoutMinutesSpecified { get; set; }

        private int _auditIntervalMinutes;

        [XmlElement(ElementName = "auditIntervalMinutes", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:14065")]
        [MinInclusive(0)]
        [MaxInclusive(525600)]
        public int AuditIntervalMinutes
        {
            get => _auditIntervalMinutes;
            set
            {
                AuditIntervalMinutesSpecified = true;
                _auditIntervalMinutes = value;
            }
        }

        [XmlIgnore]
        protected bool AuditIntervalMinutesSpecified { get; set; }

        private int _maximumCacheSize;

        [XmlElement(ElementName = "maximumCacheSize", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:14065")]
        [MinInclusive(0)]
        public int MaximumCacheSize
        {
            get => _maximumCacheSize;
            set
            {
                MaximumCacheSizeSpecified = true;
                _maximumCacheSize = value;
            }
        }

        [XmlIgnore]
        protected bool MaximumCacheSizeSpecified { get; set; }

        private string _dnsTypeDefaultValue;

        [XmlElement(ElementName = "dnsTypeDefaultValue", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:14065")]
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

        private string _useDnsSrvDefaultValue;

        [XmlElement(ElementName = "useDnsSrvDefaultValue", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:14065")]
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

        private string _srvPrefixDefaultValue;

        [XmlElement(ElementName = "srvPrefixDefaultValue", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:14065")]
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

        private string _outboundProxyDefaultValue;

        [XmlElement(ElementName = "outboundProxyDefaultValue", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:14065")]
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

        private string _transportTypeDefaultValue;

        [XmlElement(ElementName = "transportTypeDefaultValue", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:14065")]
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

        private string _secureRtpDefaultValue;

        [XmlElement(ElementName = "secureRtpDefaultValue", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:14065")]
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
