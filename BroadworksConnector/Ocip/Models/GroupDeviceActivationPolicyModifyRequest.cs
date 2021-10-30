using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the Device Activation policy of a group.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f3a93cf15de4abd7903673e44ee3e07b:4076""}]")]
    public class GroupDeviceActivationPolicyModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:4076")]
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
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:4076")]
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

        private bool _useGroupSettings;

        [XmlElement(ElementName = "useGroupSettings", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:4076")]
        public bool UseGroupSettings
        {
            get => _useGroupSettings;
            set
            {
                UseGroupSettingsSpecified = true;
                _useGroupSettings = value;
            }
        }

        [XmlIgnore]
        protected bool UseGroupSettingsSpecified { get; set; }

        private bool _allowActivationCodeRequestByUser;

        [XmlElement(ElementName = "allowActivationCodeRequestByUser", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:4076")]
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
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:4076")]
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
