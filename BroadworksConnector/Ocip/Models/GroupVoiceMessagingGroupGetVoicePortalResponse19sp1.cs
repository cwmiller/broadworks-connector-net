using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupVoiceMessagingGroupGetVoicePortalRequest19sp1.
    /// 
    /// The following elements are only used in XS data mode:
    /// enableExtendedScope
    /// 
    /// Replaced by: GroupVoiceMessagingGroupGetVoicePortalResponse21sp1 in AS data mode.
    /// <see cref="GroupVoiceMessagingGroupGetVoicePortalRequest19sp1"/>
    /// <see cref="GroupVoiceMessagingGroupGetVoicePortalResponse21sp1"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""240b50f54d060859e5e275082fdf49f9:4662""}]")]
    public class GroupVoiceMessagingGroupGetVoicePortalResponse19sp1 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected string _serviceUserId;

        [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:4662")]
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
        protected bool ServiceUserIdSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ServiceInstanceReadProfile19sp1 _serviceInstanceProfile;

        [XmlElement(ElementName = "serviceInstanceProfile", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:4662")]
        public BroadWorksConnector.Ocip.Models.ServiceInstanceReadProfile19sp1 ServiceInstanceProfile
        {
            get => _serviceInstanceProfile;
            set
            {
                ServiceInstanceProfileSpecified = true;
                _serviceInstanceProfile = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceInstanceProfileSpecified { get; set; }

        protected bool _isActive;

        [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:4662")]
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

        protected bool _enableExtendedScope;

        [XmlElement(ElementName = "enableExtendedScope", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:4662")]
        public bool EnableExtendedScope
        {
            get => _enableExtendedScope;
            set
            {
                EnableExtendedScopeSpecified = true;
                _enableExtendedScope = value;
            }
        }

        [XmlIgnore]
        protected bool EnableExtendedScopeSpecified { get; set; }

        protected bool _allowIdentificationByPhoneNumberOrVoiceMailAliasesOnLogin;

        [XmlElement(ElementName = "allowIdentificationByPhoneNumberOrVoiceMailAliasesOnLogin", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:4662")]
        public bool AllowIdentificationByPhoneNumberOrVoiceMailAliasesOnLogin
        {
            get => _allowIdentificationByPhoneNumberOrVoiceMailAliasesOnLogin;
            set
            {
                AllowIdentificationByPhoneNumberOrVoiceMailAliasesOnLoginSpecified = true;
                _allowIdentificationByPhoneNumberOrVoiceMailAliasesOnLogin = value;
            }
        }

        [XmlIgnore]
        protected bool AllowIdentificationByPhoneNumberOrVoiceMailAliasesOnLoginSpecified { get; set; }

        protected bool _useVoicePortalWizard;

        [XmlElement(ElementName = "useVoicePortalWizard", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:4662")]
        public bool UseVoicePortalWizard
        {
            get => _useVoicePortalWizard;
            set
            {
                UseVoicePortalWizardSpecified = true;
                _useVoicePortalWizard = value;
            }
        }

        [XmlIgnore]
        protected bool UseVoicePortalWizardSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.VoicePortalExternalRoutingScope _voicePortalExternalRoutingScope;

        [XmlElement(ElementName = "voicePortalExternalRoutingScope", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:4662")]
        public BroadWorksConnector.Ocip.Models.VoicePortalExternalRoutingScope VoicePortalExternalRoutingScope
        {
            get => _voicePortalExternalRoutingScope;
            set
            {
                VoicePortalExternalRoutingScopeSpecified = true;
                _voicePortalExternalRoutingScope = value;
            }
        }

        [XmlIgnore]
        protected bool VoicePortalExternalRoutingScopeSpecified { get; set; }

        protected bool _useExternalRouting;

        [XmlElement(ElementName = "useExternalRouting", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:4662")]
        public bool UseExternalRouting
        {
            get => _useExternalRouting;
            set
            {
                UseExternalRoutingSpecified = true;
                _useExternalRouting = value;
            }
        }

        [XmlIgnore]
        protected bool UseExternalRoutingSpecified { get; set; }

        protected string _externalRoutingAddress;

        [XmlElement(ElementName = "externalRoutingAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:4662")]
        [MinLength(1)]
        [MaxLength(161)]
        public string ExternalRoutingAddress
        {
            get => _externalRoutingAddress;
            set
            {
                ExternalRoutingAddressSpecified = true;
                _externalRoutingAddress = value;
            }
        }

        [XmlIgnore]
        protected bool ExternalRoutingAddressSpecified { get; set; }

        protected string _homeZoneName;

        [XmlElement(ElementName = "homeZoneName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:4662")]
        [MinLength(1)]
        [MaxLength(80)]
        public string HomeZoneName
        {
            get => _homeZoneName;
            set
            {
                HomeZoneNameSpecified = true;
                _homeZoneName = value;
            }
        }

        [XmlIgnore]
        protected bool HomeZoneNameSpecified { get; set; }

        protected string _networkClassOfService;

        [XmlElement(ElementName = "networkClassOfService", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:4662")]
        [MinLength(1)]
        [MaxLength(40)]
        public string NetworkClassOfService
        {
            get => _networkClassOfService;
            set
            {
                NetworkClassOfServiceSpecified = true;
                _networkClassOfService = value;
            }
        }

        [XmlIgnore]
        protected bool NetworkClassOfServiceSpecified { get; set; }

    }
}
