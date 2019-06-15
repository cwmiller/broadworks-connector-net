using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserScheduleGetEventRequest.
    /// The response contains collection of event details of a requested schedule.
        /// <see cref="UserScheduleGetEventRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserScheduleGetEventDetailListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private List<BroadWorksConnector.Ocip.Models.ScheduleEvents> _scheduleEvents;

        [XmlElement(ElementName = "scheduleEvents", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.ScheduleEvents> ScheduleEvents {
            get => _scheduleEvents;
            set {
                ScheduleEventsSpecified = true;
                _scheduleEvents = value;
            }
        }

        [XmlIgnore]
        public bool ScheduleEventsSpecified { get; set; }
        
    }
}
