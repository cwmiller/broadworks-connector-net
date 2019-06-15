using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the file repository information.
    /// The response is either SystemFileRepositoryDeviceGetResponse or ErrorResponse.
    /// 
    /// Replaced by: SystemFileRepositoryDeviceGetRequest16
        /// <see cref="SystemFileRepositoryDeviceGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="SystemFileRepositoryDeviceGetRequest16"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemFileRepositoryDeviceGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
