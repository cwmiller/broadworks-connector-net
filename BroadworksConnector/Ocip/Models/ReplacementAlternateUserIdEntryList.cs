using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// A list of alternate user ids that that replaces a previously configured list.
    /// By convention, an element of this type may be set nill to clear the list.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class ReplacementAlternateUserIdEntryList 
    {

        
        private List<BroadWorksConnector.Ocip.Models.AlternateUserIdEntry> _alternateUserId;

        [XmlElement(ElementName = "alternateUserId", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.AlternateUserIdEntry> AlternateUserId {
            get => _alternateUserId;
            set {
                AlternateUserIdSpecified = true;
                _alternateUserId = value;
            }
        }

        [XmlIgnore]
        public bool AlternateUserIdSpecified { get; set; }
        
    }
}
