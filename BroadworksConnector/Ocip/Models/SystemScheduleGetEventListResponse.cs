using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemScheduleGetEventListRequest.
    /// The response contains a list of events.
    /// <see cref="SystemScheduleGetEventListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:15938""}]")]
    public class SystemScheduleGetEventListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected List<string> _eventName = new List<string>();

        [XmlElement(ElementName = "eventName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:15938")]
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
