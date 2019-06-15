using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// A list of communication barring profiles that replaces a previously configured list.
    /// By convention, an element of this type may be set nil to clear the list.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class CommunicationBarringProfileReplacementList 
    {

        
        private List<string> _profileName;

        [XmlElement(ElementName = "profileName", IsNullable = false, Namespace = "")]
        public List<string> ProfileName {
            get => _profileName;
            set {
                ProfileNameSpecified = true;
                _profileName = value;
            }
        }

        [XmlIgnore]
        public bool ProfileNameSpecified { get; set; }
        
    }
}
