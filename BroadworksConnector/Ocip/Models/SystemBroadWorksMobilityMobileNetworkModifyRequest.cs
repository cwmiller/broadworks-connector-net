using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify a Mobile Network.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f7ae3539fd471e995b07dc1bf8836e2d:932""}]")]
    public class SystemBroadWorksMobilityMobileNetworkModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _name;

        [XmlElement(ElementName = "name", IsNullable = false, Namespace = "")]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:932")]
        [MinLength(1)]
        [MaxLength(80)]
        public string Name
        {
            get => _name;
            set
            {
                NameSpecified = true;
                _name = value;
            }
        }

        [XmlIgnore]
        public bool NameSpecified { get; set; }

        private string _newName;

        [XmlElement(ElementName = "newName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:932")]
        [MinLength(1)]
        [MaxLength(80)]
        public string NewName
        {
            get => _newName;
            set
            {
                NewNameSpecified = true;
                _newName = value;
            }
        }

        [XmlIgnore]
        public bool NewNameSpecified { get; set; }

        private string _scfSignalingNetAddress;

        [XmlElement(ElementName = "scfSignalingNetAddress", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:932")]
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
        public bool ScfSignalingNetAddressSpecified { get; set; }

        private int? _scfSignalingPort;

        [XmlElement(ElementName = "scfSignalingPort", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:932")]
        [MinInclusive(1)]
        [MaxInclusive(65535)]
        public int? ScfSignalingPort
        {
            get => _scfSignalingPort;
            set
            {
                ScfSignalingPortSpecified = true;
                _scfSignalingPort = value;
            }
        }

        [XmlIgnore]
        public bool ScfSignalingPortSpecified { get; set; }

        private int _refreshPeriodSeconds;

        [XmlElement(ElementName = "refreshPeriodSeconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:932")]
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
        public bool RefreshPeriodSecondsSpecified { get; set; }

        private int _maxConsecutiveFailures;

        [XmlElement(ElementName = "maxConsecutiveFailures", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:932")]
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
        public bool MaxConsecutiveFailuresSpecified { get; set; }

        private int _maxResponseWaitTimeMilliseconds;

        [XmlElement(ElementName = "maxResponseWaitTimeMilliseconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:932")]
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
        public bool MaxResponseWaitTimeMillisecondsSpecified { get; set; }

        private bool _enableAnnouncementSuppression;

        [XmlElement(ElementName = "enableAnnouncementSuppression", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:932")]
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
        public bool EnableAnnouncementSuppressionSpecified { get; set; }

        private string _serviceAccessCodeListName;

        [XmlElement(ElementName = "serviceAccessCodeListName", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:932")]
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
        public bool ServiceAccessCodeListNameSpecified { get; set; }

    }
}
