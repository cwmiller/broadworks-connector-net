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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""b009175f2a2a9d38115e319a6ad64d7f:327""}]")]
    public class ResellerCallAdmissionControlPoliciesGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _enableCallAdmissionControl;

        [XmlElement(ElementName = "enableCallAdmissionControl", IsNullable = false, Namespace = "")]
        [Group(@"b009175f2a2a9d38115e319a6ad64d7f:327")]
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

        private int _maxConcurrentNetworkSessions;

        [XmlElement(ElementName = "maxConcurrentNetworkSessions", IsNullable = false, Namespace = "")]
        [Group(@"b009175f2a2a9d38115e319a6ad64d7f:327")]
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

        private int _maxConcurrentNetworkSessionsThreshold;

        [XmlElement(ElementName = "maxConcurrentNetworkSessionsThreshold", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"b009175f2a2a9d38115e319a6ad64d7f:327")]
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

        private int _maxNetworkCallsPerSecond;

        [XmlElement(ElementName = "maxNetworkCallsPerSecond", IsNullable = false, Namespace = "")]
        [Group(@"b009175f2a2a9d38115e319a6ad64d7f:327")]
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

        private int _maxNetworkCallsPerSecondThreshold;

        [XmlElement(ElementName = "maxNetworkCallsPerSecondThreshold", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"b009175f2a2a9d38115e319a6ad64d7f:327")]
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

        private int _maxConcurrentExternalSIPRECSessions;

        [XmlElement(ElementName = "maxConcurrentExternalSIPRECSessions", IsNullable = false, Namespace = "")]
        [Group(@"b009175f2a2a9d38115e319a6ad64d7f:327")]
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

        private int _maxConcurrentExternalSIPRECSessionsThreshold;

        [XmlElement(ElementName = "maxConcurrentExternalSIPRECSessionsThreshold", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"b009175f2a2a9d38115e319a6ad64d7f:327")]
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
