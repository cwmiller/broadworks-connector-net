using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get information for a system Number Portability Query Status.
    /// The response is either SystemNumberPortabilityQueryStatusGetResponse or ErrorResponse.
        /// <see cref="SystemNumberPortabilityQueryStatusGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemNumberPortabilityQueryStatusGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _status;

        [XmlElement(ElementName = "status", IsNullable = false, Namespace = "")]
        public string Status {
            get => _status;
            set {
                StatusSpecified = true;
                _status = value;
            }
        }

        [XmlIgnore]
        public bool StatusSpecified { get; set; }
        
    }
}
