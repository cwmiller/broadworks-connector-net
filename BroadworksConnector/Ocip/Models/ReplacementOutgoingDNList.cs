using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// A list of outgoing dns that replaces a previously configured list.
    /// By convention, an element of this type may be set nill to clear the list.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class ReplacementOutgoingDNList 
    {

        
        private List<string> _phoneNumber;

        [XmlElement(ElementName = "phoneNumber", IsNullable = false, Namespace = "")]
        public List<string> PhoneNumber {
            get => _phoneNumber;
            set {
                PhoneNumberSpecified = true;
                _phoneNumber = value;
            }
        }

        [XmlIgnore]
        public bool PhoneNumberSpecified { get; set; }
        
    }
}
