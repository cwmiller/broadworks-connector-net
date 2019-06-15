using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Contains the music on hold user source configuration.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class MusicOnHoldUserSourceRead16 
    {

        
        private BroadWorksConnector.Ocip.Models.MusicOnHoldUserMessageSelection _messageSourceSelection;

        [XmlElement(ElementName = "messageSourceSelection", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.MusicOnHoldUserMessageSelection MessageSourceSelection {
            get => _messageSourceSelection;
            set {
                MessageSourceSelectionSpecified = true;
                _messageSourceSelection = value;
            }
        }

        [XmlIgnore]
        public bool MessageSourceSelectionSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.MusicOnHoldUserSourceRead16CustomSource _customSource;

        [XmlElement(ElementName = "customSource", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.MusicOnHoldUserSourceRead16CustomSource CustomSource {
            get => _customSource;
            set {
                CustomSourceSpecified = true;
                _customSource = value;
            }
        }

        [XmlIgnore]
        public bool CustomSourceSpecified { get; set; }
        
    }
}
