using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get a system holiday schedule.
    /// The response is either a SystemHolidayScheduleGetResponse or an ErrorResponse.
    /// <see cref="SystemHolidayScheduleGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:27660""}]")]
    public class SystemHolidayScheduleGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemHolidayScheduleGetResponse>
    {

        protected string _holidayScheduleName;

        [XmlElement(ElementName = "holidayScheduleName", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:27660")]
        [MinLength(1)]
        [MaxLength(40)]
        public string HolidayScheduleName
        {
            get => _holidayScheduleName;
            set
            {
                HolidayScheduleNameSpecified = true;
                _holidayScheduleName = value;
            }
        }

        [XmlIgnore]
        protected bool HolidayScheduleNameSpecified { get; set; }

    }
}
