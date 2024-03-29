using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the ResellerCallAdmissionControlPoliciesGetRequest.
    /// The response contains the reseller call admission control policies information.
    /// <see cref="ResellerCallAdmissionControlPoliciesGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d45e381d6dbac771631649063122a42e:329""}]")]
    public class ResellerCallAdmissionControlPoliciesGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _enableCallAdmissionControl;

        [XmlElement(ElementName = "enableCallAdmissionControl", IsNullable = false, Namespace = "")]
        [Group(@"d45e381d6dbac771631649063122a42e:329")]
        public bool EnableCallAdmissionControl
        {
            get => _enableCallAdmissionControl;
            set
            {
                EnableCallAdmissionControlSpecified = true;
                _enableCallAdmissionControl = value;
            }
        }

        [XmlIgnore]
        protected bool EnableCallAdmissionControlSpecified { get; set; }

        protected int _maxConcurrentNetworkSessions;

        [XmlElement(ElementName = "maxConcurrentNetworkSessions", IsNullable = false, Namespace = "")]
        [Group(@"d45e381d6dbac771631649063122a42e:329")]
        [MinInclusive(0)]
        [MaxInclusive(2147483647)]
        public int MaxConcurrentNetworkSessions
        {
            get => _maxConcurrentNetworkSessions;
            set
            {
                MaxConcurrentNetworkSessionsSpecified = true;
                _maxConcurrentNetworkSessions = value;
            }
        }

        [XmlIgnore]
        protected bool MaxConcurrentNetworkSessionsSpecified { get; set; }

        protected int _maxConcurrentNetworkSessionsThreshold;

        [XmlElement(ElementName = "maxConcurrentNetworkSessionsThreshold", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d45e381d6dbac771631649063122a42e:329")]
        [MinInclusive(1)]
        [MaxInclusive(2147483647)]
        public int MaxConcurrentNetworkSessionsThreshold
        {
            get => _maxConcurrentNetworkSessionsThreshold;
            set
            {
                MaxConcurrentNetworkSessionsThresholdSpecified = true;
                _maxConcurrentNetworkSessionsThreshold = value;
            }
        }

        [XmlIgnore]
        protected bool MaxConcurrentNetworkSessionsThresholdSpecified { get; set; }

        protected int _maxNetworkCallsPerSecond;

        [XmlElement(ElementName = "maxNetworkCallsPerSecond", IsNullable = false, Namespace = "")]
        [Group(@"d45e381d6dbac771631649063122a42e:329")]
        [MinInclusive(0)]
        [MaxInclusive(2147483647)]
        public int MaxNetworkCallsPerSecond
        {
            get => _maxNetworkCallsPerSecond;
            set
            {
                MaxNetworkCallsPerSecondSpecified = true;
                _maxNetworkCallsPerSecond = value;
            }
        }

        [XmlIgnore]
        protected bool MaxNetworkCallsPerSecondSpecified { get; set; }

        protected int _maxNetworkCallsPerSecondThreshold;

        [XmlElement(ElementName = "maxNetworkCallsPerSecondThreshold", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d45e381d6dbac771631649063122a42e:329")]
        [MinInclusive(1)]
        [MaxInclusive(2147483647)]
        public int MaxNetworkCallsPerSecondThreshold
        {
            get => _maxNetworkCallsPerSecondThreshold;
            set
            {
                MaxNetworkCallsPerSecondThresholdSpecified = true;
                _maxNetworkCallsPerSecondThreshold = value;
            }
        }

        [XmlIgnore]
        protected bool MaxNetworkCallsPerSecondThresholdSpecified { get; set; }

        protected int _maxConcurrentExternalSIPRECSessions;

        [XmlElement(ElementName = "maxConcurrentExternalSIPRECSessions", IsNullable = false, Namespace = "")]
        [Group(@"d45e381d6dbac771631649063122a42e:329")]
        [MinInclusive(0)]
        [MaxInclusive(2147483647)]
        public int MaxConcurrentExternalSIPRECSessions
        {
            get => _maxConcurrentExternalSIPRECSessions;
            set
            {
                MaxConcurrentExternalSIPRECSessionsSpecified = true;
                _maxConcurrentExternalSIPRECSessions = value;
            }
        }

        [XmlIgnore]
        protected bool MaxConcurrentExternalSIPRECSessionsSpecified { get; set; }

        protected int _maxConcurrentExternalSIPRECSessionsThreshold;

        [XmlElement(ElementName = "maxConcurrentExternalSIPRECSessionsThreshold", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d45e381d6dbac771631649063122a42e:329")]
        [MinInclusive(1)]
        [MaxInclusive(2147483647)]
        public int MaxConcurrentExternalSIPRECSessionsThreshold
        {
            get => _maxConcurrentExternalSIPRECSessionsThreshold;
            set
            {
                MaxConcurrentExternalSIPRECSessionsThresholdSpecified = true;
                _maxConcurrentExternalSIPRECSessionsThreshold = value;
            }
        }

        [XmlIgnore]
        protected bool MaxConcurrentExternalSIPRECSessionsThresholdSpecified { get; set; }

    }
}
