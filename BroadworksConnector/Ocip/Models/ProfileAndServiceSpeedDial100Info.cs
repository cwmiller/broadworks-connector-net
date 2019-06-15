using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// This is the configuration parameters for Speed Dial 100 service
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class ProfileAndServiceSpeedDial100Info 
    {

        
        private string _prefix;

        [XmlElement(ElementName = "prefix", IsNullable = false, Namespace = "")]
        public string Prefix {
            get => _prefix;
            set {
                PrefixSpecified = true;
                _prefix = value;
            }
        }

        [XmlIgnore]
        public bool PrefixSpecified { get; set; }
        
        private List<BroadWorksConnector.Ocip.Models.SpeedDial100Entry> _speedDialEntry;

        [XmlElement(ElementName = "speedDialEntry", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.SpeedDial100Entry> SpeedDialEntry {
            get => _speedDialEntry;
            set {
                SpeedDialEntrySpecified = true;
                _speedDialEntry = value;
            }
        }

        [XmlIgnore]
        public bool SpeedDialEntrySpecified { get; set; }
        
    }
}
