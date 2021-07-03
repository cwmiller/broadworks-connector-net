using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the Device Activation policy of a service provider or an enterprise.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f1088f4c5ceb30d524d2ba0f8097c393:2863""}]")]
    public class ServiceProviderDeviceActivationPolicyModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:2863")]
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

        private bool _useServiceProviderSettings;

        [XmlElement(ElementName = "useServiceProviderSettings", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:2863")]
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
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:2863")]
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
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:2863")]
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
