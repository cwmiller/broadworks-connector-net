using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The response to a SystemBroadWorksMobilityGetRequest19sp1.
    /// Replaced by SystemBroadWorksMobilityGetResponse21
    /// <see cref="SystemBroadWorksMobilityGetRequest19sp1"/>
    /// <see cref="SystemBroadWorksMobilityGetResponse21"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:34175""}]")]
    public class SystemBroadWorksMobilityGetResponse19sp1 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _enableLocationServices;

        [XmlElement(ElementName = "enableLocationServices", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:34175")]
        public bool EnableLocationServices
        {
            get => _enableLocationServices;
            set
            {
                EnableLocationServicesSpecified = true;
                _enableLocationServices = value;
            }
        }

        [XmlIgnore]
        public bool EnableLocationServicesSpecified { get; set; }

        private bool _enableMSRNLookup;

        [XmlElement(ElementName = "enableMSRNLookup", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:34175")]
        public bool EnableMSRNLookup
        {
            get => _enableMSRNLookup;
            set
            {
                EnableMSRNLookupSpecified = true;
                _enableMSRNLookup = value;
            }
        }

        [XmlIgnore]
        public bool EnableMSRNLookupSpecified { get; set; }

        private bool _enableMobileStateChecking;

        [XmlElement(ElementName = "enableMobileStateChecking", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:34175")]
        public bool EnableMobileStateChecking
        {
            get => _enableMobileStateChecking;
            set
            {
                EnableMobileStateCheckingSpecified = true;
                _enableMobileStateChecking = value;
            }
        }

        [XmlIgnore]
        public bool EnableMobileStateCheckingSpecified { get; set; }

        private bool _denyCallOriginations;

        [XmlElement(ElementName = "denyCallOriginations", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:34175")]
        public bool DenyCallOriginations
        {
            get => _denyCallOriginations;
            set
            {
                DenyCallOriginationsSpecified = true;
                _denyCallOriginations = value;
            }
        }

        [XmlIgnore]
        public bool DenyCallOriginationsSpecified { get; set; }

        private bool _denyCallTerminations;

        [XmlElement(ElementName = "denyCallTerminations", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:34175")]
        public bool DenyCallTerminations
        {
            get => _denyCallTerminations;
            set
            {
                DenyCallTerminationsSpecified = true;
                _denyCallTerminations = value;
            }
        }

        [XmlIgnore]
        public bool DenyCallTerminationsSpecified { get; set; }

        private int _imrnTimeoutMillisecnds;

        [XmlElement(ElementName = "imrnTimeoutMillisecnds", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:34175")]
        [MinInclusive(100)]
        [MaxInclusive(60000)]
        public int ImrnTimeoutMillisecnds
        {
            get => _imrnTimeoutMillisecnds;
            set
            {
                ImrnTimeoutMillisecndsSpecified = true;
                _imrnTimeoutMillisecnds = value;
            }
        }

        [XmlIgnore]
        public bool ImrnTimeoutMillisecndsSpecified { get; set; }

        private string _scfSignalingNetAddress;

        [XmlElement(ElementName = "scfSignalingNetAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:34175")]
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

        private int _scfSignalingPort;

        [XmlElement(ElementName = "scfSignalingPort", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:34175")]
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
        public bool ScfSignalingPortSpecified { get; set; }

        private int _refreshPeriodSeconds;

        [XmlElement(ElementName = "refreshPeriodSeconds", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:34175")]
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
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:34175")]
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
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:34175")]
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
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:34175")]
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

    }
}
