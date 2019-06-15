using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The service policy profile key.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class ServicePolicyProfileKey 
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
        
        private BroadWorksConnector.Ocip.Models.ServicePolicyProfileCategory _category;

        [XmlElement(ElementName = "category", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.ServicePolicyProfileCategory Category {
            get => _category;
            set {
                CategorySpecified = true;
                _category = value;
            }
        }

        [XmlIgnore]
        public bool CategorySpecified { get; set; }
        
    }
}
