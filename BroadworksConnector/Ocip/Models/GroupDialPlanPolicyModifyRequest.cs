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
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f3a93cf15de4abd7903673e44ee3e07b:3987""}]")]
    public class GroupDialPlanPolicyModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:3987")]
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
        public bool ServiceProviderIdSpecified { get; set; }

        private string _groupId;

        [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:3987")]
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
        public bool GroupIdSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.GroupDialPlanPolicySettingLevel _useSetting;

        [XmlElement(ElementName = "useSetting", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:3987")]
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
        public bool UseSettingSpecified { get; set; }

        private bool _requiresAccessCodeForPublicCalls;

        [XmlElement(ElementName = "requiresAccessCodeForPublicCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:3987")]
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
        public bool RequiresAccessCodeForPublicCallsSpecified { get; set; }

        private bool _allowE164PublicCalls;

        [XmlElement(ElementName = "allowE164PublicCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:3987")]
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
        public bool AllowE164PublicCallsSpecified { get; set; }

        private bool _preferE164NumberFormatForCallbackServices;

        [XmlElement(ElementName = "preferE164NumberFormatForCallbackServices", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:3987")]
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
        public bool PreferE164NumberFormatForCallbackServicesSpecified { get; set; }

        private string _publicDigitMap;

        [XmlElement(ElementName = "publicDigitMap", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:3987")]
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
        public bool PublicDigitMapSpecified { get; set; }

        private string _privateDigitMap;

        [XmlElement(ElementName = "privateDigitMap", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:3987")]
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
        public bool PrivateDigitMapSpecified { get; set; }

    }
}
