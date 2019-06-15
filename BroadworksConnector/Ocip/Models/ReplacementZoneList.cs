using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Contains an ordered list of zones to use to replace the current list of zones in an Office Zone.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class ReplacementZoneList 
    {

        
        private List<string> _zoneName;

        [XmlElement(ElementName = "zoneName", IsNullable = false, Namespace = "")]
        public List<string> ZoneName {
            get => _zoneName;
            set {
                ZoneNameSpecified = true;
                _zoneName = value;
            }
        }

        [XmlIgnore]
        public bool ZoneNameSpecified { get; set; }
        
    }
}
