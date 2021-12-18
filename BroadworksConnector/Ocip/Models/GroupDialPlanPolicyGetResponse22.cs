using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupDialPlanPolicyGetRequest22
    /// The following elements are only used in AS data mode:
    /// overrideResolvedDeviceDigitMap
    /// The following elements are only used in AS data mode and not returned in XS data mode:
    /// deviceDigitMap
    /// <see cref="GroupDialPlanPolicyGetRequest22"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f3a93cf15de4abd7903673e44ee3e07b:4804""}]")]
    public class GroupDialPlanPolicyGetResponse22 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.GroupDialPlanPolicySettingLevel _useSetting;

        [XmlElement(ElementName = "useSetting", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:4804")]
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
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:4804")]
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
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:4804")]
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
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:4804")]
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

        [XmlElement(ElementName = "publicDigitMap", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:4804")]
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

        [XmlElement(ElementName = "privateDigitMap", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:4804")]
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
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:4804")]
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

        [XmlElement(ElementName = "deviceDigitMap", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:4804")]
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
