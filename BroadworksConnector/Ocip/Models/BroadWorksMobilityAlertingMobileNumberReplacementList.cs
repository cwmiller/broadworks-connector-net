using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// A list of Mobile Numbers to be alerted.
    /// By convention, an element of this type may be set nil to clear the list.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class BroadWorksMobilityAlertingMobileNumberReplacementList 
    {

        
        private List<string> _mobileNumber;

        [XmlElement(ElementName = "mobileNumber", IsNullable = false, Namespace = "")]
        public List<string> MobileNumber {
            get => _mobileNumber;
            set {
                MobileNumberSpecified = true;
                _mobileNumber = value;
            }
        }

        [XmlIgnore]
        public bool MobileNumberSpecified { get; set; }
        
    }
}
