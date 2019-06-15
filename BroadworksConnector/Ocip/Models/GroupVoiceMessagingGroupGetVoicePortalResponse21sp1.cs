using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupVoiceMessagingGroupGetVoicePortalRequest21sp1.
    /// 
    /// The following elements are only used in XS data mode:
    /// enableExtendedScope
    /// 
    /// The following elements are only used in AS data mode:
    /// expressMode, value "false" is returned in XS data mode.
        /// <see cref="GroupVoiceMessagingGroupGetVoicePortalRequest21sp1"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupVoiceMessagingGroupGetVoicePortalResponse21sp1 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private string _serviceUserId;

        [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
        public string ServiceUserId {
            get => _serviceUserId;
            set {
                ServiceUserIdSpecified = true;
                _serviceUserId = value;
            }
        }

        [XmlIgnore]
        public bool ServiceUserIdSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.ServiceInstanceReadProfile19sp1 _serviceInstanceProfile;

        [XmlElement(ElementName = "serviceInstanceProfile", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.ServiceInstanceReadProfile19sp1 ServiceInstanceProfile {
            get => _serviceInstanceProfile;
            set {
                ServiceInstanceProfileSpecified = true;
                _serviceInstanceProfile = value;
            }
        }

        [XmlIgnore]
        public bool ServiceInstanceProfileSpecified { get; set; }
        
        private bool _isActive;

        [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
        public bool IsActive {
            get => _isActive;
            set {
                IsActiveSpecified = true;
                _isActive = value;
            }
        }

        [XmlIgnore]
        public bool IsActiveSpecified { get; set; }
        
        private bool _enableExtendedScope;

        [XmlElement(ElementName = "enableExtendedScope", IsNullable = false, Namespace = "")]
        public bool EnableExtendedScope {
            get => _enableExtendedScope;
            set {
                EnableExtendedScopeSpecified = true;
                _enableExtendedScope = value;
            }
        }

        [XmlIgnore]
        public bool EnableExtendedScopeSpecified { get; set; }
        
        private bool _allowIdentificationByPhoneNumberOrVoiceMailAliasesOnLogin;

        [XmlElement(ElementName = "allowIdentificationByPhoneNumberOrVoiceMailAliasesOnLogin", IsNullable = false, Namespace = "")]
        public bool AllowIdentificationByPhoneNumberOrVoiceMailAliasesOnLogin {
            get => _allowIdentificationByPhoneNumberOrVoiceMailAliasesOnLogin;
            set {
                AllowIdentificationByPhoneNumberOrVoiceMailAliasesOnLoginSpecified = true;
                _allowIdentificationByPhoneNumberOrVoiceMailAliasesOnLogin = value;
            }
        }

        [XmlIgnore]
        public bool AllowIdentificationByPhoneNumberOrVoiceMailAliasesOnLoginSpecified { get; set; }
        
        private bool _useVoicePortalWizard;

        [XmlElement(ElementName = "useVoicePortalWizard", IsNullable = false, Namespace = "")]
        public bool UseVoicePortalWizard {
            get => _useVoicePortalWizard;
            set {
                UseVoicePortalWizardSpecified = true;
                _useVoicePortalWizard = value;
            }
        }

        [XmlIgnore]
        public bool UseVoicePortalWizardSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.VoicePortalExternalRoutingScope _voicePortalExternalRoutingScope;

        [XmlElement(ElementName = "voicePortalExternalRoutingScope", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.VoicePortalExternalRoutingScope VoicePortalExternalRoutingScope {
            get => _voicePortalExternalRoutingScope;
            set {
                VoicePortalExternalRoutingScopeSpecified = true;
                _voicePortalExternalRoutingScope = value;
            }
        }

        [XmlIgnore]
        public bool VoicePortalExternalRoutingScopeSpecified { get; set; }
        
        private bool _useExternalRouting;

        [XmlElement(ElementName = "useExternalRouting", IsNullable = false, Namespace = "")]
        public bool UseExternalRouting {
            get => _useExternalRouting;
            set {
                UseExternalRoutingSpecified = true;
                _useExternalRouting = value;
            }
        }

        [XmlIgnore]
        public bool UseExternalRoutingSpecified { get; set; }
        
        private string _externalRoutingAddress;

        [XmlElement(ElementName = "externalRoutingAddress", IsNullable = false, Namespace = "")]
        public string ExternalRoutingAddress {
            get => _externalRoutingAddress;
            set {
                ExternalRoutingAddressSpecified = true;
                _externalRoutingAddress = value;
            }
        }

        [XmlIgnore]
        public bool ExternalRoutingAddressSpecified { get; set; }
        
        private string _homeZoneName;

        [XmlElement(ElementName = "homeZoneName", IsNullable = false, Namespace = "")]
        public string HomeZoneName {
            get => _homeZoneName;
            set {
                HomeZoneNameSpecified = true;
                _homeZoneName = value;
            }
        }

        [XmlIgnore]
        public bool HomeZoneNameSpecified { get; set; }
        
        private string _networkClassOfService;

        [XmlElement(ElementName = "networkClassOfService", IsNullable = false, Namespace = "")]
        public string NetworkClassOfService {
            get => _networkClassOfService;
            set {
                NetworkClassOfServiceSpecified = true;
                _networkClassOfService = value;
            }
        }

        [XmlIgnore]
        public bool NetworkClassOfServiceSpecified { get; set; }
        
        private bool _expressMode;

        [XmlElement(ElementName = "expressMode", IsNullable = false, Namespace = "")]
        public bool ExpressMode {
            get => _expressMode;
            set {
                ExpressModeSpecified = true;
                _expressMode = value;
            }
        }

        [XmlIgnore]
        public bool ExpressModeSpecified { get; set; }
        
    }
}
