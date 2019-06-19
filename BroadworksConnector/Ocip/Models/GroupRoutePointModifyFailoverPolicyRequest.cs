using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the route point failover policy.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""a27224a048c30ff69eab9209dec841cc:879""}]")]
    public class GroupRoutePointModifyFailoverPolicyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceUserId;

        [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
        [Group(@"a27224a048c30ff69eab9209dec841cc:879")]
        [MinLength(1)]
        [MaxLength(161)]
        public string ServiceUserId
        {
            get => _serviceUserId;
            set
            {
                ServiceUserIdSpecified = true;
                _serviceUserId = value;
            }
        }

        [XmlIgnore]
        public bool ServiceUserIdSpecified { get; set; }

        private bool _enableFailoverSupport;

        [XmlElement(ElementName = "enableFailoverSupport", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"a27224a048c30ff69eab9209dec841cc:879")]
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
        public bool EnableFailoverSupportSpecified { get; set; }

        private string _externalSystem;

        [XmlElement(ElementName = "externalSystem", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"a27224a048c30ff69eab9209dec841cc:879")]
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
        public bool ExternalSystemSpecified { get; set; }

        private string _failoverPhoneNumber;

        [XmlElement(ElementName = "failoverPhoneNumber", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"a27224a048c30ff69eab9209dec841cc:879")]
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
        public bool FailoverPhoneNumberSpecified { get; set; }

        private bool _perCallEnableFailoverSupport;

        [XmlElement(ElementName = "perCallEnableFailoverSupport", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"a27224a048c30ff69eab9209dec841cc:879")]
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
        public bool PerCallEnableFailoverSupportSpecified { get; set; }

        private int _perCallCallFailureTimeoutSeconds;

        [XmlElement(ElementName = "perCallCallFailureTimeoutSeconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"a27224a048c30ff69eab9209dec841cc:879")]
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
        public bool PerCallCallFailureTimeoutSecondsSpecified { get; set; }

        private int _perCallOutboundCallFailureTimeoutSeconds;

        [XmlElement(ElementName = "perCallOutboundCallFailureTimeoutSeconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"a27224a048c30ff69eab9209dec841cc:879")]
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
        public bool PerCallOutboundCallFailureTimeoutSecondsSpecified { get; set; }

        private string _perCallFailoverPhoneNumber;

        [XmlElement(ElementName = "perCallFailoverPhoneNumber", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"a27224a048c30ff69eab9209dec841cc:879")]
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
        public bool PerCallFailoverPhoneNumberSpecified { get; set; }

    }
}
