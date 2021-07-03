using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to ServiceProviderDeviceActivationPolicyGetRequest.
    /// <see cref="ServiceProviderDeviceActivationPolicyGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f1088f4c5ceb30d524d2ba0f8097c393:2845""}]")]
    public class ServiceProviderDeviceActivationPolicyGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _useServiceProviderSettings;

        [XmlElement(ElementName = "useServiceProviderSettings", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:2845")]
        public bool UseServiceProviderSettings
        {
            get => _useServiceProviderSettings;
            set
            {
                UseServiceProviderSettingsSpecified = true;
                _useServiceProviderSettings = value;
            }
        }

        [XmlIgnore]
        protected bool UseServiceProviderSettingsSpecified { get; set; }

        private bool _allowActivationCodeRequestByUser;

        [XmlElement(ElementName = "allowActivationCodeRequestByUser", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:2845")]
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
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:2845")]
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
