using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupRoutePointGetFailoverPolicyRequest.
    /// <see cref="GroupRoutePointGetFailoverPolicyRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""a27224a048c30ff69eab9209dec841cc:540""}]")]
    public class GroupRoutePointGetFailoverPolicyResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _enableFailoverSupport;

        [XmlElement(ElementName = "enableFailoverSupport", IsNullable = false, Namespace = "")]
        [Group(@"a27224a048c30ff69eab9209dec841cc:540")]
        public bool EnableFailoverSupport
        {
            get => _enableFailoverSupport;
            set
            {
                EnableFailoverSupportSpecified = true;
                _enableFailoverSupport = value;
            }
        }

        [XmlIgnore]
        protected bool EnableFailoverSupportSpecified { get; set; }

        private string _externalSystem;

        [XmlElement(ElementName = "externalSystem", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"a27224a048c30ff69eab9209dec841cc:540")]
        [MinLength(1)]
        [MaxLength(40)]
        public string ExternalSystem
        {
            get => _externalSystem;
            set
            {
                ExternalSystemSpecified = true;
                _externalSystem = value;
            }
        }

        [XmlIgnore]
        protected bool ExternalSystemSpecified { get; set; }

        private string _failoverPhoneNumber;

        [XmlElement(ElementName = "failoverPhoneNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"a27224a048c30ff69eab9209dec841cc:540")]
        [MinLength(1)]
        [MaxLength(161)]
        public string FailoverPhoneNumber
        {
            get => _failoverPhoneNumber;
            set
            {
                FailoverPhoneNumberSpecified = true;
                _failoverPhoneNumber = value;
            }
        }

        [XmlIgnore]
        protected bool FailoverPhoneNumberSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.RoutePointFailoverStatus _failoverStatus;

        [XmlElement(ElementName = "failoverStatus", IsNullable = false, Namespace = "")]
        [Group(@"a27224a048c30ff69eab9209dec841cc:540")]
        public BroadWorksConnector.Ocip.Models.RoutePointFailoverStatus FailoverStatus
        {
            get => _failoverStatus;
            set
            {
                FailoverStatusSpecified = true;
                _failoverStatus = value;
            }
        }

        [XmlIgnore]
        protected bool FailoverStatusSpecified { get; set; }

        private bool _perCallEnableFailoverSupport;

        [XmlElement(ElementName = "perCallEnableFailoverSupport", IsNullable = false, Namespace = "")]
        [Group(@"a27224a048c30ff69eab9209dec841cc:540")]
        public bool PerCallEnableFailoverSupport
        {
            get => _perCallEnableFailoverSupport;
            set
            {
                PerCallEnableFailoverSupportSpecified = true;
                _perCallEnableFailoverSupport = value;
            }
        }

        [XmlIgnore]
        protected bool PerCallEnableFailoverSupportSpecified { get; set; }

        private int _perCallCallFailureTimeoutSeconds;

        [XmlElement(ElementName = "perCallCallFailureTimeoutSeconds", IsNullable = false, Namespace = "")]
        [Group(@"a27224a048c30ff69eab9209dec841cc:540")]
        [MinInclusive(1)]
        [MaxInclusive(60)]
        public int PerCallCallFailureTimeoutSeconds
        {
            get => _perCallCallFailureTimeoutSeconds;
            set
            {
                PerCallCallFailureTimeoutSecondsSpecified = true;
                _perCallCallFailureTimeoutSeconds = value;
            }
        }

        [XmlIgnore]
        protected bool PerCallCallFailureTimeoutSecondsSpecified { get; set; }

        private int _perCallOutboundCallFailureTimeoutSeconds;

        [XmlElement(ElementName = "perCallOutboundCallFailureTimeoutSeconds", IsNullable = false, Namespace = "")]
        [Group(@"a27224a048c30ff69eab9209dec841cc:540")]
        [MinInclusive(1)]
        [MaxInclusive(60)]
        public int PerCallOutboundCallFailureTimeoutSeconds
        {
            get => _perCallOutboundCallFailureTimeoutSeconds;
            set
            {
                PerCallOutboundCallFailureTimeoutSecondsSpecified = true;
                _perCallOutboundCallFailureTimeoutSeconds = value;
            }
        }

        [XmlIgnore]
        protected bool PerCallOutboundCallFailureTimeoutSecondsSpecified { get; set; }

        private string _perCallFailoverPhoneNumber;

        [XmlElement(ElementName = "perCallFailoverPhoneNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"a27224a048c30ff69eab9209dec841cc:540")]
        [MinLength(1)]
        [MaxLength(161)]
        public string PerCallFailoverPhoneNumber
        {
            get => _perCallFailoverPhoneNumber;
            set
            {
                PerCallFailoverPhoneNumberSpecified = true;
                _perCallFailoverPhoneNumber = value;
            }
        }

        [XmlIgnore]
        protected bool PerCallFailoverPhoneNumberSpecified { get; set; }

    }
}
