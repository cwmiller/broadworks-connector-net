using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// A SIP Contact info contains the SIP registration Contact and its associated Header path
    /// The following element is only used in AS data mode and ignored in XS data mode:
    /// pathHeader
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SIPContactInfo 
    {

        
        private string _sipContact;

        [XmlElement(ElementName = "sipContact", IsNullable = false, Namespace = "")]
        public string SipContact {
            get => _sipContact;
            set {
                SipContactSpecified = true;
                _sipContact = value;
            }
        }

        [XmlIgnore]
        public bool SipContactSpecified { get; set; }
        
        private string _pathHeader;

        [XmlElement(ElementName = "pathHeader", IsNullable = false, Namespace = "")]
        public string PathHeader {
            get => _pathHeader;
            set {
                PathHeaderSpecified = true;
                _pathHeader = value;
            }
        }

        [XmlIgnore]
        public bool PathHeaderSpecified { get; set; }
        
    }
}
