using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the file repository information.
    /// The response is either SystemFileRepositoryDeviceGetResponse16 or ErrorResponse.
    /// 
    /// Replaced by: SystemFileRepositoryDeviceGetRequest20
        /// <see cref="SystemFileRepositoryDeviceGetResponse16"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="SystemFileRepositoryDeviceGetRequest20"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemFileRepositoryDeviceGetRequest16 : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
