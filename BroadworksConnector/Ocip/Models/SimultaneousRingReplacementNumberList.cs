using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// A list of Simultaneous Ring numbers that replaces a previously configured list.
    /// By convention, an element of this type may be set nill to clear the list.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SimultaneousRingReplacementNumberList 
    {

        
        private List<BroadWorksConnector.Ocip.Models.SimultaneousRingNumber> _simultaneousRingNumber;

        [XmlElement(ElementName = "simultaneousRingNumber", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.SimultaneousRingNumber> SimultaneousRingNumber {
            get => _simultaneousRingNumber;
            set {
                SimultaneousRingNumberSpecified = true;
                _simultaneousRingNumber = value;
            }
        }

        [XmlIgnore]
        public bool SimultaneousRingNumberSpecified { get; set; }
        
    }
}
