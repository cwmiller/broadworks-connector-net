using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get an existing Network Class of Service.
    /// The response is either a SystemNetworkClassOfServiceGetResponse
    /// or an ErrorResponse.
    /// Replaced by: SystemNetworkClassOfServiceGetRequest17
        /// <see cref="SystemNetworkClassOfServiceGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="SystemNetworkClassOfServiceGetRequest17"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemNetworkClassOfServiceGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
