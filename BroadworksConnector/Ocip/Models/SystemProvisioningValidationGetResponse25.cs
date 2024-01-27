using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the SystemProvisioningValidationGetRequest25.
    /// <see cref="SystemProvisioningValidationGetRequest25"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:14924""}]")]
    public class SystemProvisioningValidationGetResponse25 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _isActive;

        [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:14924")]
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
        [Group(@"da582a1f8028404e70d260cf1f891033:14924")]
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
        [Group(@"da582a1f8028404e70d260cf1f891033:14924")]
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
        [Group(@"da582a1f8028404e70d260cf1f891033:14924")]
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
        [Group(@"da582a1f8028404e70d260cf1f891033:14924")]
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
        [Group(@"da582a1f8028404e70d260cf1f891033:14924")]
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
