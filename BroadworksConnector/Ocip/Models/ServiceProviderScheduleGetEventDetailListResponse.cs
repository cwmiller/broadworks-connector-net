using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f1088f4c5ceb30d524d2ba0f8097c393:4917""}]")]
    public class ServiceProviderScheduleGetEventDetailListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private List<BroadWorksConnector.Ocip.Models.ScheduleEvents> _scheduleEventsList = new List<BroadWorksConnector.Ocip.Models.ScheduleEvents>();

        [XmlElement(ElementName = "scheduleEventsList", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:4917")]
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
        public bool ScheduleEventsListSpecified { get; set; }

    }
}
