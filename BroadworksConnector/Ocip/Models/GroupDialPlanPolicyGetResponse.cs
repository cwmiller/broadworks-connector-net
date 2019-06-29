using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupDialPlanPolicyGetRequest
    /// Replaced by: GroupDialPlanPolicyGetResponse17
    /// <see cref="GroupDialPlanPolicyGetRequest"/>
    /// <see cref="GroupDialPlanPolicyGetResponse17"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:13579""}]")]
    public class GroupDialPlanPolicyGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.GroupDialPlanPolicySettingLevel _useSetting;

        [XmlElement(ElementName = "useSetting", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:13579")]
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
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:13579")]
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
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:13579")]
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

        private string _publicDigitMap;

        [XmlElement(ElementName = "publicDigitMap", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:13579")]
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
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:13579")]
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

    }
}
