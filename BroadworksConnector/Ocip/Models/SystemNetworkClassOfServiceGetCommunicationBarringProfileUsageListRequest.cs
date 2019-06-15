using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the list of Network Classes of Service that contain a specific
    /// Communication Barring Profile.
    /// The response is either a SystemNetworkClassOfServiceGetCommunicationBarringProfileUsageListResponse
    /// or an ErrorResponse.
        /// <see cref="SystemNetworkClassOfServiceGetCommunicationBarringProfileUsageListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemNetworkClassOfServiceGetCommunicationBarringProfileUsageListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _name;

        [XmlElement(ElementName = "name", IsNullable = false, Namespace = "")]
        public string Name {
            get => _name;
            set {
                NameSpecified = true;
                _name = value;
            }
        }

        [XmlIgnore]
        public bool NameSpecified { get; set; }
        
    }
}
