using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Number of conference ports. Can either be unlimited or limited to a value between 0 and 999999.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class MeetMeConferencingConferencePorts 
    {

        
        private bool _unlimited;

        [XmlElement(ElementName = "unlimited", IsNullable = false, Namespace = "")]
        public bool Unlimited {
            get => _unlimited;
            set {
                UnlimitedSpecified = true;
                _unlimited = value;
            }
        }

        [XmlIgnore]
        public bool UnlimitedSpecified { get; set; }
        
        private int _quantity;

        [XmlElement(ElementName = "quantity", IsNullable = false, Namespace = "")]
        public int Quantity {
            get => _quantity;
            set {
                QuantitySpecified = true;
                _quantity = value;
            }
        }

        [XmlIgnore]
        public bool QuantitySpecified { get; set; }
        
    }
}
