using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the Device Activation policy of a reseller.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""b009175f2a2a9d38115e319a6ad64d7f:479""}]")]
    public class ResellerDeviceActivationPolicyModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        private string _resellerId;

        [XmlElement(ElementName = "resellerId", IsNullable = false, Namespace = "")]
        [Group(@"b009175f2a2a9d38115e319a6ad64d7f:479")]
        [MinLength(1)]
        [MaxLength(36)]
        public string ResellerId
        {
            get => _resellerId;
            set
            {
                ResellerIdSpecified = true;
                _resellerId = value;
            }
        }

        [XmlIgnore]
        protected bool ResellerIdSpecified { get; set; }

        private bool _useResellerSettings;

        [XmlElement(ElementName = "useResellerSettings", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"b009175f2a2a9d38115e319a6ad64d7f:479")]
        public bool UseResellerSettings
        {
            get => _useResellerSettings;
            set
            {
                UseResellerSettingsSpecified = true;
                _useResellerSettings = value;
            }
        }

        [XmlIgnore]
        protected bool UseResellerSettingsSpecified { get; set; }

        private bool _allowActivationCodeRequestByUser;

        [XmlElement(ElementName = "allowActivationCodeRequestByUser", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"b009175f2a2a9d38115e319a6ad64d7f:479")]
        public bool AllowActivationCodeRequestByUser
        {
            get => _allowActivationCodeRequestByUser;
            set
            {
                AllowActivationCodeRequestByUserSpecified = true;
                _allowActivationCodeRequestByUser = value;
            }
        }

        [XmlIgnore]
        protected bool AllowActivationCodeRequestByUserSpecified { get; set; }

        private bool _sendActivationCodeInEmail;

        [XmlElement(ElementName = "sendActivationCodeInEmail", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"b009175f2a2a9d38115e319a6ad64d7f:479")]
        public bool SendActivationCodeInEmail
        {
            get => _sendActivationCodeInEmail;
            set
            {
                SendActivationCodeInEmailSpecified = true;
                _sendActivationCodeInEmail = value;
            }
        }

        [XmlIgnore]
        protected bool SendActivationCodeInEmailSpecified { get; set; }

    }
}
