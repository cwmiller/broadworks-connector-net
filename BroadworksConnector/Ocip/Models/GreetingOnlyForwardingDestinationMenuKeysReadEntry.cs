using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The voice portal greeting only forwarding destination menu keys.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GreetingOnlyForwardingDestinationMenuKeysReadEntry 
    {

        
        private string _greetingOnlyForwardingDestination;

        [XmlElement(ElementName = "greetingOnlyForwardingDestination", IsNullable = false, Namespace = "")]
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
