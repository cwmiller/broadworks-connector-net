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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""fb73488c2ef4ac4400ab213b637d79a9:3629""}]")]
    public class UserScheduleGetEventDetailListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected List<BroadWorksConnector.Ocip.Models.ScheduleEvents> _scheduleEvents = new List<BroadWorksConnector.Ocip.Models.ScheduleEvents>();

        [XmlElement(ElementName = "scheduleEvents", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:3629")]
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
        protected bool ScheduleEventsSpecified { get; set; }

    }
}
