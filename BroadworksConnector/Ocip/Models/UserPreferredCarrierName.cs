using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// User can either use it's group's preferred carrier or use it's own.
    /// The user carrier name is exposed if it was previously configured.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserPreferredCarrierName 
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

        [XmlElement(ElementName = "carrier", IsNullable = false, Namespace = "")]
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
