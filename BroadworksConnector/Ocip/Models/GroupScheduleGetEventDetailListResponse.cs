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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f3a93cf15de4abd7903673e44ee3e07b:7426""}]")]
    public class GroupScheduleGetEventDetailListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private List<BroadWorksConnector.Ocip.Models.ScheduleEvents> _scheduleEventsList = new List<BroadWorksConnector.Ocip.Models.ScheduleEvents>();

        [XmlElement(ElementName = "scheduleEventsList", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:7426")]
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
