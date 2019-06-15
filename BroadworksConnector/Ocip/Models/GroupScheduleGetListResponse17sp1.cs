using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupScheduleGetListRequest17sp1.
    /// The response contains a list of group schedules. If the group belongs to an enterprise,
    /// it also contains the schedules for the enterprise.
        /// <see cref="GroupScheduleGetListRequest17sp1"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupScheduleGetListResponse17sp1 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
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
