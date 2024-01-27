using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The response to a SystemBroadWorksMobilityMobileNetworkGetRequest.
    /// <see cref="SystemBroadWorksMobilityMobileNetworkGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""9ae9f7d53e566e21347e23e20e2a2a39:1154""}]")]
    public class SystemBroadWorksMobilityMobileNetworkGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected string _scfSignalingNetAddress;

        [XmlElement(ElementName = "scfSignalingNetAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"9ae9f7d53e566e21347e23e20e2a2a39:1154")]
        [MinLength(1)]
        [MaxLength(80)]
        public string ScfSignalingNetAddress
        {
            get => _scfSignalingNetAddress;
            set
            {
                ScfSignalingNetAddressSpecified = true;
                _scfSignalingNetAddress = value;
            }
        }

        [XmlIgnore]
        protected bool ScfSignalingNetAddressSpecified { get; set; }

        protected int _scfSignalingPort;

        [XmlElement(ElementName = "scfSignalingPort", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"9ae9f7d53e566e21347e23e20e2a2a39:1154")]
        [MinInclusive(1)]
        [MaxInclusive(65535)]
        public int ScfSignalingPort
        {
            get => _scfSignalingPort;
            set
            {
                ScfSignalingPortSpecified = true;
                _scfSignalingPort = value;
            }
        }

        [XmlIgnore]
        protected bool ScfSignalingPortSpecified { get; set; }

        protected int _refreshPeriodSeconds;

        [XmlElement(ElementName = "refreshPeriodSeconds", IsNullable = false, Namespace = "")]
        [Group(@"9ae9f7d53e566e21347e23e20e2a2a39:1154")]
        [MinInclusive(10)]
        [MaxInclusive(1800)]
        public int RefreshPeriodSeconds
        {
            get => _refreshPeriodSeconds;
            set
            {
                RefreshPeriodSecondsSpecified = true;
                _refreshPeriodSeconds = value;
            }
        }

        [XmlIgnore]
        protected bool RefreshPeriodSecondsSpecified { get; set; }

        protected int _maxConsecutiveFailures;

        [XmlElement(ElementName = "maxConsecutiveFailures", IsNullable = false, Namespace = "")]
        [Group(@"9ae9f7d53e566e21347e23e20e2a2a39:1154")]
        [MinInclusive(1)]
        [MaxInclusive(10)]
        public int MaxConsecutiveFailures
        {
            get => _maxConsecutiveFailures;
            set
            {
                MaxConsecutiveFailuresSpecified = true;
                _maxConsecutiveFailures = value;
            }
        }

        [XmlIgnore]
        protected bool MaxConsecutiveFailuresSpecified { get; set; }

        protected int _maxResponseWaitTimeMilliseconds;

        [XmlElement(ElementName = "maxResponseWaitTimeMilliseconds", IsNullable = false, Namespace = "")]
        [Group(@"9ae9f7d53e566e21347e23e20e2a2a39:1154")]
        [MinInclusive(100)]
        [MaxInclusive(10000)]
        public int MaxResponseWaitTimeMilliseconds
        {
            get => _maxResponseWaitTimeMilliseconds;
            set
            {
                MaxResponseWaitTimeMillisecondsSpecified = true;
                _maxResponseWaitTimeMilliseconds = value;
            }
        }

        [XmlIgnore]
        protected bool MaxResponseWaitTimeMillisecondsSpecified { get; set; }

        protected bool _enableAnnouncementSuppression;

        [XmlElement(ElementName = "enableAnnouncementSuppression", IsNullable = false, Namespace = "")]
        [Group(@"9ae9f7d53e566e21347e23e20e2a2a39:1154")]
        public bool EnableAnnouncementSuppression
        {
            get => _enableAnnouncementSuppression;
            set
            {
                EnableAnnouncementSuppressionSpecified = true;
                _enableAnnouncementSuppression = value;
            }
        }

        [XmlIgnore]
        protected bool EnableAnnouncementSuppressionSpecified { get; set; }

        protected string _serviceAccessCodeListName;

        [XmlElement(ElementName = "serviceAccessCodeListName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"9ae9f7d53e566e21347e23e20e2a2a39:1154")]
        [MinLength(1)]
        [MaxLength(80)]
        public string ServiceAccessCodeListName
        {
            get => _serviceAccessCodeListName;
            set
            {
                ServiceAccessCodeListNameSpecified = true;
                _serviceAccessCodeListName = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceAccessCodeListNameSpecified { get; set; }

    }
}
