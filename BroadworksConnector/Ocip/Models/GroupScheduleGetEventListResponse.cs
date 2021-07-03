using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupScheduleGetEventListRequest.
    /// The response contains a list of events.
    /// <see cref="GroupScheduleGetEventListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f3a93cf15de4abd7903673e44ee3e07b:7459""}]")]
    public class GroupScheduleGetEventListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private List<string> _eventName = new List<string>();

        [XmlElement(ElementName = "eventName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:7459")]
        [MinLength(1)]
        [MaxLength(40)]
        public List<string> EventName
        {
            get => _eventName;
            set
            {
                EventNameSpecified = true;
                _eventName = value;
            }
        }

        [XmlIgnore]
        protected bool EventNameSpecified { get; set; }

    }
}
