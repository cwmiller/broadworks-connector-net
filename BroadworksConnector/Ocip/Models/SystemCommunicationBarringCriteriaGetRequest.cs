using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get an existing Communication Barring Criteria.
    /// The response is either a SystemCommunicationBarringCriteriaGetResponse
    /// or an ErrorResponse.
    /// Replaced by: SystemCommunicationBarringCriteriaGetRequest17
        /// <see cref="SystemCommunicationBarringCriteriaGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="SystemCommunicationBarringCriteriaGetRequest17"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemCommunicationBarringCriteriaGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
