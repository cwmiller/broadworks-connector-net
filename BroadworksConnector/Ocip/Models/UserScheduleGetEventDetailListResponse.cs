using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""53d18cc797d03d802cbc411ad821f1d4:3584""}]")]
    public class UserScheduleGetEventDetailListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private List<BroadWorksConnector.Ocip.Models.ScheduleEvents> _scheduleEvents = new List<BroadWorksConnector.Ocip.Models.ScheduleEvents>();

        [XmlElement(ElementName = "scheduleEvents", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:3584")]
        public List<BroadWorksConnector.Ocip.Models.ScheduleEvents> ScheduleEvents
        {
            get => _scheduleEvents;
            set
            {
                ScheduleEventsSpecified = true;
                _scheduleEvents = value;
            }
        }

        [XmlIgnore]
        public bool ScheduleEventsSpecified { get; set; }

    }
}
