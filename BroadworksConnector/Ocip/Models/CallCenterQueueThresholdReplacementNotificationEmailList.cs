using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// List of email addresses to which the Call Center Queue Threshold email is sent. The list replaces a previously configured list.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class CallCenterQueueThresholdReplacementNotificationEmailList 
    {

        
        private List<string> _emailAddress;

        [XmlElement(ElementName = "emailAddress", IsNullable = false, Namespace = "")]
        public List<string> EmailAddress {
            get => _emailAddress;
            set {
                EmailAddressSpecified = true;
                _emailAddress = value;
            }
        }

        [XmlIgnore]
        public bool EmailAddressSpecified { get; set; }
        
    }
}
