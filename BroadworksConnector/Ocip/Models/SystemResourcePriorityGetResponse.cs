using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the SystemResourcePriorityGetRequest.
    /// The response contains the system Resource Priority service attributes.
        /// <see cref="SystemResourcePriorityGetRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemResourcePriorityGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private bool _sendResourcePriorityToNetwork;

        [XmlElement(ElementName = "sendResourcePriorityToNetwork", IsNullable = false, Namespace = "")]
        public bool SendResourcePriorityToNetwork {
            get => _sendResourcePriorityToNetwork;
            set {
                SendResourcePriorityToNetworkSpecified = true;
                _sendResourcePriorityToNetwork = value;
            }
        }

        [XmlIgnore]
        public bool SendResourcePriorityToNetworkSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.ResourcePriorityValue _resourcePriority;

        [XmlElement(ElementName = "resourcePriority", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.ResourcePriorityValue ResourcePriority {
            get => _resourcePriority;
            set {
                ResourcePrioritySpecified = true;
                _resourcePriority = value;
            }
        }

        [XmlIgnore]
        public bool ResourcePrioritySpecified { get; set; }
        
    }
}
