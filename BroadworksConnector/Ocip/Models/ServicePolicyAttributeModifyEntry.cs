using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The service policy attributes name and value pair.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class ServicePolicyAttributeModifyEntry 
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
        
        private string _value;

        [XmlElement(ElementName = "value", IsNullable = true, Namespace = "")]
        public string Value {
            get => _value;
            set {
                ValueSpecified = true;
                _value = value;
            }
        }

        [XmlIgnore]
        public bool ValueSpecified { get; set; }
        
    }
}
