using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to ServiceProviderScheduleGetEventDetailListRequest.
    /// The response contains a list of ScheduleEvents.
    /// If the scheduleKey doesn't refer to an existing schedule on the AS, then the response will be empty.
        /// <see cref="ServiceProviderScheduleGetEventDetailListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class ServiceProviderScheduleGetEventDetailListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private List<BroadWorksConnector.Ocip.Models.ScheduleEvents> _scheduleEventsList;

        [XmlElement(ElementName = "scheduleEventsList", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.ScheduleEvents> ScheduleEventsList {
            get => _scheduleEventsList;
            set {
                ScheduleEventsListSpecified = true;
                _scheduleEventsList = value;
            }
        }

        [XmlIgnore]
        public bool ScheduleEventsListSpecified { get; set; }
        
    }
}
