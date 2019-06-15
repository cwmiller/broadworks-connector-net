using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// A list of SIP contacts that replaces a previously configured list.
    /// By convention, an element of this type may be set nill to clear the list.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class ReplacementContactList22 
    {

        
        private List<BroadWorksConnector.Ocip.Models.SIPContactInfo> _contact;

        [XmlElement(ElementName = "contact", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.SIPContactInfo> Contact {
            get => _contact;
            set {
                ContactSpecified = true;
                _contact = value;
            }
        }

        [XmlIgnore]
        public bool ContactSpecified { get; set; }
        
    }
}
