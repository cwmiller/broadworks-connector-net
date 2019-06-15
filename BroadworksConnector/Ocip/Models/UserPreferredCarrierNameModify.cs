using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// User can either use it's group's preferred carrier or use it's own.
    /// You can use the group's preferred carrier without clearing the user carrier name --
    /// in this case, the user carrier name is retained.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserPreferredCarrierNameModify 
    {

        
        private bool _useGroupPreferredCarrier;

        [XmlElement(ElementName = "useGroupPreferredCarrier", IsNullable = false, Namespace = "")]
        public bool UseGroupPreferredCarrier {
            get => _useGroupPreferredCarrier;
            set {
                UseGroupPreferredCarrierSpecified = true;
                _useGroupPreferredCarrier = value;
            }
        }

        [XmlIgnore]
        public bool UseGroupPreferredCarrierSpecified { get; set; }
        
        private string _carrier;

        [XmlElement(ElementName = "carrier", IsNullable = true, Namespace = "")]
        public string Carrier {
            get => _carrier;
            set {
                CarrierSpecified = true;
                _carrier = value;
            }
        }

        [XmlIgnore]
        public bool CarrierSpecified { get; set; }
        
    }
}
