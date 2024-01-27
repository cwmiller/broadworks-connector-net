using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to modify the system's provisioning validation attributes.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// 
    /// The following elements are only used in AS data mode and ignored in XS data mode:
    /// denyMobilityNumberAsRedirectionDestination
    /// denyEnterpriseNumberAsNetworkLocationDestination
    /// denyAutoAttendantIdentityAsAutoAttendantTransferNumber
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:14950""}]")]
    public class SystemProvisioningValidationModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected bool _isActive;

        [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:14950")]
        public bool IsActive
        {
            get => _isActive;
            set
            {
                IsActiveSpecified = true;
                _isActive = value;
            }
        }

        [XmlIgnore]
        protected bool IsActiveSpecified { get; set; }

        protected bool _isNetworkServerQueryActive;

        [XmlElement(ElementName = "isNetworkServerQueryActive", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:14950")]
        public bool IsNetworkServerQueryActive
        {
            get => _isNetworkServerQueryActive;
            set
            {
                IsNetworkServerQueryActiveSpecified = true;
                _isNetworkServerQueryActive = value;
            }
        }

        [XmlIgnore]
        protected bool IsNetworkServerQueryActiveSpecified { get; set; }

        protected int _timeoutSeconds;

        [XmlElement(ElementName = "timeoutSeconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:14950")]
        [MinInclusive(1)]
        [MaxInclusive(30)]
        public int TimeoutSeconds
        {
            get => _timeoutSeconds;
            set
            {
                TimeoutSecondsSpecified = true;
                _timeoutSeconds = value;
            }
        }

        [XmlIgnore]
        protected bool TimeoutSecondsSpecified { get; set; }

        protected bool _denyMobilityNumberAsRedirectionDestination;

        [XmlElement(ElementName = "denyMobilityNumberAsRedirectionDestination", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:14950")]
        public bool DenyMobilityNumberAsRedirectionDestination
        {
            get => _denyMobilityNumberAsRedirectionDestination;
            set
            {
                DenyMobilityNumberAsRedirectionDestinationSpecified = true;
                _denyMobilityNumberAsRedirectionDestination = value;
            }
        }

        [XmlIgnore]
        protected bool DenyMobilityNumberAsRedirectionDestinationSpecified { get; set; }

        protected bool _denyEnterpriseNumberAsNetworkLocationDestination;

        [XmlElement(ElementName = "denyEnterpriseNumberAsNetworkLocationDestination", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:14950")]
        public bool DenyEnterpriseNumberAsNetworkLocationDestination
        {
            get => _denyEnterpriseNumberAsNetworkLocationDestination;
            set
            {
                DenyEnterpriseNumberAsNetworkLocationDestinationSpecified = true;
                _denyEnterpriseNumberAsNetworkLocationDestination = value;
            }
        }

        [XmlIgnore]
        protected bool DenyEnterpriseNumberAsNetworkLocationDestinationSpecified { get; set; }

        protected bool _denyAutoAttendantIdentityAsAutoAttendantTransferNumber;

        [XmlElement(ElementName = "denyAutoAttendantIdentityAsAutoAttendantTransferNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:14950")]
        public bool DenyAutoAttendantIdentityAsAutoAttendantTransferNumber
        {
            get => _denyAutoAttendantIdentityAsAutoAttendantTransferNumber;
            set
            {
                DenyAutoAttendantIdentityAsAutoAttendantTransferNumberSpecified = true;
                _denyAutoAttendantIdentityAsAutoAttendantTransferNumber = value;
            }
        }

        [XmlIgnore]
        protected bool DenyAutoAttendantIdentityAsAutoAttendantTransferNumberSpecified { get; set; }

    }
}
