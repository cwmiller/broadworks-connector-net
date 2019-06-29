using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the system interface attributes for Messaging Server/BroadCloud.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:2126""}]")]
    public class SystemBroadCloudModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _provisioningUrl;

        [XmlElement(ElementName = "provisioningUrl", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:2126")]
        [MinLength(1)]
        [MaxLength(256)]
        public string ProvisioningUrl
        {
            get => _provisioningUrl;
            set
            {
                ProvisioningUrlSpecified = true;
                _provisioningUrl = value;
            }
        }

        [XmlIgnore]
        protected bool ProvisioningUrlSpecified { get; set; }

        private string _provisioningUserId;

        [XmlElement(ElementName = "provisioningUserId", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:2126")]
        [MinLength(1)]
        [MaxLength(80)]
        public string ProvisioningUserId
        {
            get => _provisioningUserId;
            set
            {
                ProvisioningUserIdSpecified = true;
                _provisioningUserId = value;
            }
        }

        [XmlIgnore]
        protected bool ProvisioningUserIdSpecified { get; set; }

        private string _provisioningPassword;

        [XmlElement(ElementName = "provisioningPassword", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:2126")]
        [MinLength(1)]
        [MaxLength(20)]
        public string ProvisioningPassword
        {
            get => _provisioningPassword;
            set
            {
                ProvisioningPasswordSpecified = true;
                _provisioningPassword = value;
            }
        }

        [XmlIgnore]
        protected bool ProvisioningPasswordSpecified { get; set; }

        private bool _enableSynchronization;

        [XmlElement(ElementName = "enableSynchronization", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:2126")]
        public bool EnableSynchronization
        {
            get => _enableSynchronization;
            set
            {
                EnableSynchronizationSpecified = true;
                _enableSynchronization = value;
            }
        }

        [XmlIgnore]
        protected bool EnableSynchronizationSpecified { get; set; }

    }
}
