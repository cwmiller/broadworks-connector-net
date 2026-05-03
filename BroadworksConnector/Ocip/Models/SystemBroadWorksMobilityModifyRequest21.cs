using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the BroadWorks Mobility system parameters.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""9ae9f7d53e566e21347e23e20e2a2a39:1259""}]")]
    public class SystemBroadWorksMobilityModifyRequest21 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected bool? _enableLocationServices;

        [XmlElement(ElementName = "enableLocationServices", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"9ae9f7d53e566e21347e23e20e2a2a39:1259")]
        public bool? EnableLocationServices
        {
            get => _enableLocationServices;
            set
            {
                EnableLocationServicesSpecified = (value != null);
                _enableLocationServices = value;
            }
        }

        [XmlIgnore]
        protected bool EnableLocationServicesSpecified { get; set; }

        protected bool? _enableMSRNLookup;

        [XmlElement(ElementName = "enableMSRNLookup", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"9ae9f7d53e566e21347e23e20e2a2a39:1259")]
        public bool? EnableMSRNLookup
        {
            get => _enableMSRNLookup;
            set
            {
                EnableMSRNLookupSpecified = (value != null);
                _enableMSRNLookup = value;
            }
        }

        [XmlIgnore]
        protected bool EnableMSRNLookupSpecified { get; set; }

        protected bool? _enableMobileStateChecking;

        [XmlElement(ElementName = "enableMobileStateChecking", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"9ae9f7d53e566e21347e23e20e2a2a39:1259")]
        public bool? EnableMobileStateChecking
        {
            get => _enableMobileStateChecking;
            set
            {
                EnableMobileStateCheckingSpecified = (value != null);
                _enableMobileStateChecking = value;
            }
        }

        [XmlIgnore]
        protected bool EnableMobileStateCheckingSpecified { get; set; }

        protected bool? _denyCallOriginations;

        [XmlElement(ElementName = "denyCallOriginations", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"9ae9f7d53e566e21347e23e20e2a2a39:1259")]
        public bool? DenyCallOriginations
        {
            get => _denyCallOriginations;
            set
            {
                DenyCallOriginationsSpecified = (value != null);
                _denyCallOriginations = value;
            }
        }

        [XmlIgnore]
        protected bool DenyCallOriginationsSpecified { get; set; }

        protected bool? _denyCallTerminations;

        [XmlElement(ElementName = "denyCallTerminations", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"9ae9f7d53e566e21347e23e20e2a2a39:1259")]
        public bool? DenyCallTerminations
        {
            get => _denyCallTerminations;
            set
            {
                DenyCallTerminationsSpecified = (value != null);
                _denyCallTerminations = value;
            }
        }

        [XmlIgnore]
        protected bool DenyCallTerminationsSpecified { get; set; }

        protected int? _imrnTimeoutMilliseconds;

        [XmlElement(ElementName = "imrnTimeoutMilliseconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"9ae9f7d53e566e21347e23e20e2a2a39:1259")]
        [MinInclusive(100)]
        [MaxInclusive(60000)]
        public int? ImrnTimeoutMilliseconds
        {
            get => _imrnTimeoutMilliseconds;
            set
            {
                ImrnTimeoutMillisecondsSpecified = (value != null);
                _imrnTimeoutMilliseconds = value;
            }
        }

        [XmlIgnore]
        protected bool ImrnTimeoutMillisecondsSpecified { get; set; }

        protected bool? _enableInternalCLIDDelivery;

        [XmlElement(ElementName = "enableInternalCLIDDelivery", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"9ae9f7d53e566e21347e23e20e2a2a39:1259")]
        public bool? EnableInternalCLIDDelivery
        {
            get => _enableInternalCLIDDelivery;
            set
            {
                EnableInternalCLIDDeliverySpecified = (value != null);
                _enableInternalCLIDDelivery = value;
            }
        }

        [XmlIgnore]
        protected bool EnableInternalCLIDDeliverySpecified { get; set; }

        protected bool? _includeRedirectForMobilityTermination;

        [XmlElement(ElementName = "includeRedirectForMobilityTermination", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"9ae9f7d53e566e21347e23e20e2a2a39:1259")]
        public bool? IncludeRedirectForMobilityTermination
        {
            get => _includeRedirectForMobilityTermination;
            set
            {
                IncludeRedirectForMobilityTerminationSpecified = (value != null);
                _includeRedirectForMobilityTermination = value;
            }
        }

        [XmlIgnore]
        protected bool IncludeRedirectForMobilityTerminationSpecified { get; set; }

        protected bool? _enableInternalCLIDDeliveryAccessLocations;

        [XmlElement(ElementName = "enableInternalCLIDDeliveryAccessLocations", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"9ae9f7d53e566e21347e23e20e2a2a39:1259")]
        public bool? EnableInternalCLIDDeliveryAccessLocations
        {
            get => _enableInternalCLIDDeliveryAccessLocations;
            set
            {
                EnableInternalCLIDDeliveryAccessLocationsSpecified = (value != null);
                _enableInternalCLIDDeliveryAccessLocations = value;
            }
        }

        [XmlIgnore]
        protected bool EnableInternalCLIDDeliveryAccessLocationsSpecified { get; set; }

        protected bool? _enableEnhancedUnreachableStateChecking;

        [XmlElement(ElementName = "enableEnhancedUnreachableStateChecking", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"9ae9f7d53e566e21347e23e20e2a2a39:1259")]
        public bool? EnableEnhancedUnreachableStateChecking
        {
            get => _enableEnhancedUnreachableStateChecking;
            set
            {
                EnableEnhancedUnreachableStateCheckingSpecified = (value != null);
                _enableEnhancedUnreachableStateChecking = value;
            }
        }

        [XmlIgnore]
        protected bool EnableEnhancedUnreachableStateCheckingSpecified { get; set; }

        protected bool? _enableNetworkCallBarringStatusCheck;

        [XmlElement(ElementName = "enableNetworkCallBarringStatusCheck", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"9ae9f7d53e566e21347e23e20e2a2a39:1259")]
        public bool? EnableNetworkCallBarringStatusCheck
        {
            get => _enableNetworkCallBarringStatusCheck;
            set
            {
                EnableNetworkCallBarringStatusCheckSpecified = (value != null);
                _enableNetworkCallBarringStatusCheck = value;
            }
        }

        [XmlIgnore]
        protected bool EnableNetworkCallBarringStatusCheckSpecified { get; set; }

        protected string _networkTranslationIndex;

        /// <remarks>Eraseable</remarks>
        [XmlElement(ElementName = "networkTranslationIndex", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"9ae9f7d53e566e21347e23e20e2a2a39:1259")]
        [MinLength(1)]
        [MaxLength(128)]
        public string NetworkTranslationIndex
        {
            get => _networkTranslationIndex;
            set
            {
                NetworkTranslationIndexSpecified = true;
                _networkTranslationIndex = value;
            }
        }

        [XmlIgnore]
        protected bool NetworkTranslationIndexSpecified { get; set; }

        protected bool? _sendPhoneContextToNetworkLocationForNonE164PhoneNumber;

        [XmlElement(ElementName = "sendPhoneContextToNetworkLocationForNonE164PhoneNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"9ae9f7d53e566e21347e23e20e2a2a39:1259")]
        public bool? SendPhoneContextToNetworkLocationForNonE164PhoneNumber
        {
            get => _sendPhoneContextToNetworkLocationForNonE164PhoneNumber;
            set
            {
                SendPhoneContextToNetworkLocationForNonE164PhoneNumberSpecified = (value != null);
                _sendPhoneContextToNetworkLocationForNonE164PhoneNumber = value;
            }
        }

        [XmlIgnore]
        protected bool SendPhoneContextToNetworkLocationForNonE164PhoneNumberSpecified { get; set; }

        protected bool? _sendPhoneContextToAccessLocationForNonE164PhoneNumber;

        [XmlElement(ElementName = "sendPhoneContextToAccessLocationForNonE164PhoneNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"9ae9f7d53e566e21347e23e20e2a2a39:1259")]
        public bool? SendPhoneContextToAccessLocationForNonE164PhoneNumber
        {
            get => _sendPhoneContextToAccessLocationForNonE164PhoneNumber;
            set
            {
                SendPhoneContextToAccessLocationForNonE164PhoneNumberSpecified = (value != null);
                _sendPhoneContextToAccessLocationForNonE164PhoneNumber = value;
            }
        }

        [XmlIgnore]
        protected bool SendPhoneContextToAccessLocationForNonE164PhoneNumberSpecified { get; set; }

        protected string _phoneContextDescriptorForNonE164PhoneNumber;

        /// <remarks>Eraseable</remarks>
        [XmlElement(ElementName = "phoneContextDescriptorForNonE164PhoneNumber", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"9ae9f7d53e566e21347e23e20e2a2a39:1259")]
        [MinLength(1)]
        [MaxLength(80)]
        public string PhoneContextDescriptorForNonE164PhoneNumber
        {
            get => _phoneContextDescriptorForNonE164PhoneNumber;
            set
            {
                PhoneContextDescriptorForNonE164PhoneNumberSpecified = true;
                _phoneContextDescriptorForNonE164PhoneNumber = value;
            }
        }

        [XmlIgnore]
        protected bool PhoneContextDescriptorForNonE164PhoneNumberSpecified { get; set; }

    }
}
