using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupScheduleGetEventDetailListRequest.
    /// The response contains a list of ScheduleEvents.
    /// If the scheduleKey doesn't refer to an existing schedule on the AS, then the response will be empty.
    /// <see cref="GroupScheduleGetEventDetailListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4b0e7857796c636464362260a2f8e5ee:7163""}]")]
    public class GroupScheduleGetEventDetailListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected List<BroadWorksConnector.Ocip.Models.ScheduleEvents> _scheduleEventsList = new List<BroadWorksConnector.Ocip.Models.ScheduleEvents>();

        [XmlElement(ElementName = "scheduleEventsList", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:7163")]
        public List<BroadWorksConnector.Ocip.Models.ScheduleEvents> ScheduleEventsList
        {
            get => _scheduleEventsList;
            set
            {
                ScheduleEventsListSpecified = true;
                _scheduleEventsList = value;
            }
        }

        [XmlIgnore]
        protected bool ScheduleEventsListSpecified { get; set; }

    }
}
