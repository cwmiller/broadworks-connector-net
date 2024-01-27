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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e19a9072c2dad499e9f28837da5768db:5812""}]")]
    public class ServiceProviderScheduleGetEventDetailListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected List<BroadWorksConnector.Ocip.Models.ScheduleEvents> _scheduleEventsList = new List<BroadWorksConnector.Ocip.Models.ScheduleEvents>();

        [XmlElement(ElementName = "scheduleEventsList", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:5812")]
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
