using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupVoiceMessagingGroupGetVoicePortalRequest14.
    /// Replaced by GroupVoiceMessagingGroupGetVoicePortalResponse15
    /// <see cref="GroupVoiceMessagingGroupGetVoicePortalRequest14"/>
    /// <see cref="GroupVoiceMessagingGroupGetVoicePortalResponse15"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:16684""}]")]
    public class GroupVoiceMessagingGroupGetVoicePortalResponse14 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected string _serviceUserId;

        [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:16684")]
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

        protected BroadWorksConnector.Ocip.Models.ServiceInstanceReadProfile _serviceInstanceProfile;

        [XmlElement(ElementName = "serviceInstanceProfile", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:16684")]
        public BroadWorksConnector.Ocip.Models.ServiceInstanceReadProfile ServiceInstanceProfile
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
        [Group(@"d8f04177e438f303b41c211e518706bf:16684")]
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

        protected bool _allowIdentificationByPhoneNumberOrVoiceMailAliasesOnLogin;

        [XmlElement(ElementName = "allowIdentificationByPhoneNumberOrVoiceMailAliasesOnLogin", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:16684")]
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
        [Group(@"d8f04177e438f303b41c211e518706bf:16684")]
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
        [Group(@"d8f04177e438f303b41c211e518706bf:16684")]
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
        [Group(@"d8f04177e438f303b41c211e518706bf:16684")]
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
        [Group(@"d8f04177e438f303b41c211e518706bf:16684")]
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

    }
}
