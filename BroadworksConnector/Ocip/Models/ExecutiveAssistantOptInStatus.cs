using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Executive assistant Opt-in status with executive.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class ExecutiveAssistantOptInStatus 
    {

        
        private string _executiveUserId;

        [XmlElement(ElementName = "executiveUserId", IsNullable = false, Namespace = "")]
        public string ExecutiveUserId {
            get => _executiveUserId;
            set {
                ExecutiveUserIdSpecified = true;
                _executiveUserId = value;
            }
        }

        [XmlIgnore]
        public bool ExecutiveUserIdSpecified { get; set; }
        
        private bool _optIn;

        [XmlElement(ElementName = "optIn", IsNullable = false, Namespace = "")]
        public bool OptIn {
            get => _optIn;
            set {
                OptInSpecified = true;
                _optIn = value;
            }
        }

        [XmlIgnore]
        public bool OptInSpecified { get; set; }
        
    }
}
