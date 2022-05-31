using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the SystemBroadCloudGetRequest.
    /// The response contains the system interface attributes for Messaging Server/BroadCloud.
    /// <see cref="SystemBroadCloudGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:2524""}]")]
    public class SystemBroadCloudGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected string _provisioningUrl;

        [XmlElement(ElementName = "provisioningUrl", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:2524")]
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

        protected string _provisioningUserId;

        [XmlElement(ElementName = "provisioningUserId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:2524")]
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

        protected bool _enableSynchronization;

        [XmlElement(ElementName = "enableSynchronization", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:2524")]
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
