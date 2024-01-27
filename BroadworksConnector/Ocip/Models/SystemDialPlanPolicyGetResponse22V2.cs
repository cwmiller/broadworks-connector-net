using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemDialPlanPolicyGetRequest22V2
    /// The following elements are only used in AS data mode:
    /// overrideResolvedDeviceDigitMap
    /// The following elements are only used in AS data mode and not returned in XS data mode:
    /// deviceDigitMap
    /// performInternalTranslationsWithOAC
    /// permissiveOACDialing
    /// <see cref="SystemDialPlanPolicyGetRequest22V2"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:9281""}]")]
    public class SystemDialPlanPolicyGetResponse22V2 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _requiresAccessCodeForPublicCalls;

        [XmlElement(ElementName = "requiresAccessCodeForPublicCalls", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:9281")]
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

        protected bool _allowE164PublicCalls;

        [XmlElement(ElementName = "allowE164PublicCalls", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:9281")]
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

        protected bool _preferE164NumberFormatForCallbackServices;

        [XmlElement(ElementName = "preferE164NumberFormatForCallbackServices", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:9281")]
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

        protected string _publicDigitMap;

        [XmlElement(ElementName = "publicDigitMap", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:9281")]
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

        protected string _privateDigitMap;

        [XmlElement(ElementName = "privateDigitMap", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:9281")]
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

        protected bool _overrideResolvedDeviceDigitMap;

        [XmlElement(ElementName = "overrideResolvedDeviceDigitMap", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:9281")]
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

        protected string _deviceDigitMap;

        [XmlElement(ElementName = "deviceDigitMap", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:9281")]
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

        protected bool _performInternalTranslationsWithOAC;

        [XmlElement(ElementName = "performInternalTranslationsWithOAC", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:9281")]
        public bool PerformInternalTranslationsWithOAC
        {
            get => _performInternalTranslationsWithOAC;
            set
            {
                PerformInternalTranslationsWithOACSpecified = true;
                _performInternalTranslationsWithOAC = value;
            }
        }

        [XmlIgnore]
        protected bool PerformInternalTranslationsWithOACSpecified { get; set; }

        protected bool _permissiveOACDialing;

        [XmlElement(ElementName = "permissiveOACDialing", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:9281")]
        public bool PermissiveOACDialing
        {
            get => _permissiveOACDialing;
            set
            {
                PermissiveOACDialingSpecified = true;
                _permissiveOACDialing = value;
            }
        }

        [XmlIgnore]
        protected bool PermissiveOACDialingSpecified { get; set; }

    }
}
