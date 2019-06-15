using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the UserSpeedDial100GetListRequest.
    /// 
    /// Replaced by: UserSpeedDial100GetListResponse17Sp1
        /// <see cref="UserSpeedDial100GetListRequest"/>
        /// <see cref="UserSpeedDial100GetListResponse17Sp1"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserSpeedDial100GetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
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
