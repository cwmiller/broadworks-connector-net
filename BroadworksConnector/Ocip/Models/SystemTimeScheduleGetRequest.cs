using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get a system time schedule.
    /// The response is either a SystemTimeScheduleGetResponse or an ErrorResponse.
    /// <see cref="SystemTimeScheduleGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:36358""}]")]
    public class SystemTimeScheduleGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemTimeScheduleGetResponse>
    {

        protected string _timeScheduleName;

        [XmlElement(ElementName = "timeScheduleName", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:36358")]
        [MinLength(1)]
        [MaxLength(40)]
        public string TimeScheduleName
        {
            get => _timeScheduleName;
            set
            {
                TimeScheduleNameSpecified = true;
                _timeScheduleName = value;
            }
        }

        [XmlIgnore]
        protected bool TimeScheduleNameSpecified { get; set; }

    }
}
