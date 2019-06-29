using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the system level data associated with Dial Plan Policy.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:8143""}]")]
    public class SystemDialPlanPolicyModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private bool _requiresAccessCodeForPublicCalls;

        [XmlElement(ElementName = "requiresAccessCodeForPublicCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:8143")]
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
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:8143")]
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
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:8143")]
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
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:8143")]
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
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:8143")]
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
