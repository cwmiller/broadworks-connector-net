using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Sequential Ring Location.
    /// Replaced By: SequentialRingLocation14sp4
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SequentialRingLocation 
    {

        
        private string _phoneNumber;

        [XmlElement(ElementName = "phoneNumber", IsNullable = false, Namespace = "")]
        public string PhoneNumber {
            get => _phoneNumber;
            set {
                PhoneNumberSpecified = true;
                _phoneNumber = value;
            }
        }

        [XmlIgnore]
        public bool PhoneNumberSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.SequentialRingNumberOfRings _numberOfRings;

        [XmlElement(ElementName = "numberOfRings", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.SequentialRingNumberOfRings NumberOfRings {
            get => _numberOfRings;
            set {
                NumberOfRingsSpecified = true;
                _numberOfRings = value;
            }
        }

        [XmlIgnore]
        public bool NumberOfRingsSpecified { get; set; }
        
    }
}
