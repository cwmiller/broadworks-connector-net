using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the reseller call admission control policies.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d45e381d6dbac771631649063122a42e:351""}]")]
    public class ResellerCallAdmissionControlPoliciesModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _resellerId;

        [XmlElement(ElementName = "resellerId", IsNullable = false, Namespace = "")]
        [Group(@"d45e381d6dbac771631649063122a42e:351")]
        [MinLength(1)]
        [MaxLength(36)]
        public string ResellerId
        {
            get => _resellerId;
            set
            {
                ResellerIdSpecified = true;
                _resellerId = value;
            }
        }

        [XmlIgnore]
        protected bool ResellerIdSpecified { get; set; }

        protected bool _enableCallAdmissionControl;

        [XmlElement(ElementName = "enableCallAdmissionControl", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d45e381d6dbac771631649063122a42e:351")]
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
        [Optional]
        [Group(@"d45e381d6dbac771631649063122a42e:351")]
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

        protected int? _maxConcurrentNetworkSessionsThreshold;

        [XmlElement(ElementName = "maxConcurrentNetworkSessionsThreshold", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"d45e381d6dbac771631649063122a42e:351")]
        [MinInclusive(1)]
        [MaxInclusive(2147483647)]
        public int? MaxConcurrentNetworkSessionsThreshold
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
        [Optional]
        [Group(@"d45e381d6dbac771631649063122a42e:351")]
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

        protected int? _maxNetworkCallsPerSecondThreshold;

        [XmlElement(ElementName = "maxNetworkCallsPerSecondThreshold", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"d45e381d6dbac771631649063122a42e:351")]
        [MinInclusive(1)]
        [MaxInclusive(2147483647)]
        public int? MaxNetworkCallsPerSecondThreshold
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
        [Optional]
        [Group(@"d45e381d6dbac771631649063122a42e:351")]
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

        protected int? _maxConcurrentExternalSIPRECSessionsThreshold;

        [XmlElement(ElementName = "maxConcurrentExternalSIPRECSessionsThreshold", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"d45e381d6dbac771631649063122a42e:351")]
        [MinInclusive(1)]
        [MaxInclusive(2147483647)]
        public int? MaxConcurrentExternalSIPRECSessionsThreshold
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
