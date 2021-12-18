using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupDeviceActivationPolicyGetRequest.
    /// <see cref="GroupDeviceActivationPolicyGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f3a93cf15de4abd7903673e44ee3e07b:4059""}]")]
    public class GroupDeviceActivationPolicyGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _useGroupSettings;

        [XmlElement(ElementName = "useGroupSettings", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:4059")]
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
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:4059")]
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
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:4059")]
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
