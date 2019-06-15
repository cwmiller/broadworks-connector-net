using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The voice portal greeting only forwarding destination menu keys modify entry.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GreetingOnlyForwardingDestinationMenuKeysModifyEntry 
    {

        
        private string _greetingOnlyForwardingDestination;

        [XmlElement(ElementName = "greetingOnlyForwardingDestination", IsNullable = true, Namespace = "")]
        public string GreetingOnlyForwardingDestination {
            get => _greetingOnlyForwardingDestination;
            set {
                GreetingOnlyForwardingDestinationSpecified = true;
                _greetingOnlyForwardingDestination = value;
            }
        }

        [XmlIgnore]
        public bool GreetingOnlyForwardingDestinationSpecified { get; set; }
        
    }
}
