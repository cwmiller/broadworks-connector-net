using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserScheduleGetEventListRequest.
    /// The response contains a list of events.
    /// <see cref="UserScheduleGetEventListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""53d18cc797d03d802cbc411ad821f1d4:3617""}]")]
    public class UserScheduleGetEventListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private List<string> _eventName = new List<string>();

        [XmlElement(ElementName = "eventName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:3617")]
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
        public bool EventNameSpecified { get; set; }

    }
}
