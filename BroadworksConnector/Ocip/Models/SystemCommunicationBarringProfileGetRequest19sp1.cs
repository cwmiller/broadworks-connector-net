using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get an existing Communication Barring Profile.
    /// The response is either a SystemCommunicationBarringProfileGetResponse19sp1
    /// or an ErrorResponse.
    /// 
    /// Replaced by: SystemCommunicationBarringProfileGetRequest19sp1V2 in AS data mode
        /// <see cref="SystemCommunicationBarringProfileGetResponse19sp1"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="SystemCommunicationBarringProfileGetRequest19sp1V2"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemCommunicationBarringProfileGetRequest19sp1 : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
