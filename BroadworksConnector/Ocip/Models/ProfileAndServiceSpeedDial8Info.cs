using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// This is the configuration parameters for Speed Dial 8 service
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class ProfileAndServiceSpeedDial8Info 
    {

        
        private List<BroadWorksConnector.Ocip.Models.SpeedDial8Entry> _speedDialEntry;

        [XmlElement(ElementName = "speedDialEntry", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.SpeedDial8Entry> SpeedDialEntry {
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
