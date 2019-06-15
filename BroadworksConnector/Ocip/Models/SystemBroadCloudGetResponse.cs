using System;
using System.Xml.Serialization;
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
     
    public class SystemBroadCloudGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private string _provisioningUrl;

        [XmlElement(ElementName = "provisioningUrl", IsNullable = false, Namespace = "")]
        public string ProvisioningUrl {
            get => _provisioningUrl;
            set {
                ProvisioningUrlSpecified = true;
                _provisioningUrl = value;
            }
        }

        [XmlIgnore]
        public bool ProvisioningUrlSpecified { get; set; }
        
        private string _provisioningUserId;

        [XmlElement(ElementName = "provisioningUserId", IsNullable = false, Namespace = "")]
        public string ProvisioningUserId {
            get => _provisioningUserId;
            set {
                ProvisioningUserIdSpecified = true;
                _provisioningUserId = value;
            }
        }

        [XmlIgnore]
        public bool ProvisioningUserIdSpecified { get; set; }
        
        private bool _enableSynchronization;

        [XmlElement(ElementName = "enableSynchronization", IsNullable = false, Namespace = "")]
        public bool EnableSynchronization {
            get => _enableSynchronization;
            set {
                EnableSynchronizationSpecified = true;
                _enableSynchronization = value;
            }
        }

        [XmlIgnore]
        public bool EnableSynchronizationSpecified { get; set; }
        
    }
}
