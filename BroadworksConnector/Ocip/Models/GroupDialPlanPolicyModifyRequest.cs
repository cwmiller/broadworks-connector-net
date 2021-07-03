using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the Group level data associated with Dial Plan Policy.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// The following elements are only used in AS data mode and ignored in XS data mode:
    /// overrideResolvedDeviceDigitMap
    /// deviceDigitMap
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f3a93cf15de4abd7903673e44ee3e07b:4851""}]")]
    public class GroupDialPlanPolicyModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:4851")]
        [MinLength(1)]
        [MaxLength(30)]
        public string ServiceProviderId
        {
            get => _serviceProviderId;
            set
            {
                ServiceProviderIdSpecified = true;
                _serviceProviderId = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceProviderIdSpecified { get; set; }

        private string _groupId;

        [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:4851")]
        [MinLength(1)]
        [MaxLength(30)]
        public string GroupId
        {
            get => _groupId;
            set
            {
                GroupIdSpecified = true;
                _groupId = value;
            }
        }

        [XmlIgnore]
        protected bool GroupIdSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.GroupDialPlanPolicySettingLevel _useSetting;

        [XmlElement(ElementName = "useSetting", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:4851")]
        public BroadWorksConnector.Ocip.Models.GroupDialPlanPolicySettingLevel UseSetting
        {
            get => _useSetting;
            set
            {
                UseSettingSpecified = true;
                _useSetting = value;
            }
        }

        [XmlIgnore]
        protected bool UseSettingSpecified { get; set; }

        private bool _requiresAccessCodeForPublicCalls;

        [XmlElement(ElementName = "requiresAccessCodeForPublicCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:4851")]
        public bool RequiresAccessCodeForPublicCalls
        {
            get => _requiresAccessCodeForPublicCalls;
            set
            {
                RequiresAccessCodeForPublicCallsSpecified = true;
                _requiresAccessCodeForPublicCalls = value;
            }
        }

        [XmlIgnore]
        protected bool RequiresAccessCodeForPublicCallsSpecified { get; set; }

        private bool _allowE164PublicCalls;

        [XmlElement(ElementName = "allowE164PublicCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:4851")]
        public bool AllowE164PublicCalls
        {
            get => _allowE164PublicCalls;
            set
            {
                AllowE164PublicCallsSpecified = true;
                _allowE164PublicCalls = value;
            }
        }

        [XmlIgnore]
        protected bool AllowE164PublicCallsSpecified { get; set; }

        private bool _preferE164NumberFormatForCallbackServices;

        [XmlElement(ElementName = "preferE164NumberFormatForCallbackServices", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:4851")]
        public bool PreferE164NumberFormatForCallbackServices
        {
            get => _preferE164NumberFormatForCallbackServices;
            set
            {
                PreferE164NumberFormatForCallbackServicesSpecified = true;
                _preferE164NumberFormatForCallbackServices = value;
            }
        }

        [XmlIgnore]
        protected bool PreferE164NumberFormatForCallbackServicesSpecified { get; set; }

        private string _publicDigitMap;

        [XmlElement(ElementName = "publicDigitMap", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:4851")]
        [MinLength(1)]
        [MaxLength(2048)]
        public string PublicDigitMap
        {
            get => _publicDigitMap;
            set
            {
                PublicDigitMapSpecified = true;
                _publicDigitMap = value;
            }
        }

        [XmlIgnore]
        protected bool PublicDigitMapSpecified { get; set; }

        private string _privateDigitMap;

        [XmlElement(ElementName = "privateDigitMap", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:4851")]
        [MinLength(1)]
        [MaxLength(2048)]
        public string PrivateDigitMap
        {
            get => _privateDigitMap;
            set
            {
                PrivateDigitMapSpecified = true;
                _privateDigitMap = value;
            }
        }

        [XmlIgnore]
        protected bool PrivateDigitMapSpecified { get; set; }

        private bool _overrideResolvedDeviceDigitMap;

        [XmlElement(ElementName = "overrideResolvedDeviceDigitMap", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:4851")]
        public bool OverrideResolvedDeviceDigitMap
        {
            get => _overrideResolvedDeviceDigitMap;
            set
            {
                OverrideResolvedDeviceDigitMapSpecified = true;
                _overrideResolvedDeviceDigitMap = value;
            }
        }

        [XmlIgnore]
        protected bool OverrideResolvedDeviceDigitMapSpecified { get; set; }

        private string _deviceDigitMap;

        [XmlElement(ElementName = "deviceDigitMap", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:4851")]
        [MinLength(1)]
        [MaxLength(2048)]
        public string DeviceDigitMap
        {
            get => _deviceDigitMap;
            set
            {
                DeviceDigitMapSpecified = true;
                _deviceDigitMap = value;
            }
        }

        [XmlIgnore]
        protected bool DeviceDigitMapSpecified { get; set; }

    }
}
