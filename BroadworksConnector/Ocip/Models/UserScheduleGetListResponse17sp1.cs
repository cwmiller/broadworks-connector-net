using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserScheduleGetListRequest17sp1.
    /// The response contains a list of schedules viewable by the user. It contains the schedules
    /// defined for the user and the group the user belongs to. If the user belongs to an enterprise,
    /// the list also contains the schedules defined for the enterprise.
        /// <see cref="UserScheduleGetListRequest17sp1"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserScheduleGetListResponse17sp1 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private List<BroadWorksConnector.Ocip.Models.ScheduleGlobalKey> _scheduleGlobalKey;

        [XmlElement(ElementName = "scheduleGlobalKey", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.ScheduleGlobalKey> ScheduleGlobalKey {
            get => _scheduleGlobalKey;
            set {
                ScheduleGlobalKeySpecified = true;
                _scheduleGlobalKey = value;
            }
        }

        [XmlIgnore]
        public bool ScheduleGlobalKeySpecified { get; set; }
        
    }
}
