using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupHolidayScheduleGetListRequest.
    /// The response contains all the group's holiday schedule name.
    /// <see cref="GroupHolidayScheduleGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:10360""}]")]
    public class GroupHolidayScheduleGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected List<string> _holidayScheduleName = new List<string>();

        [XmlElement(ElementName = "holidayScheduleName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:10360")]
        [MinLength(1)]
        [MaxLength(40)]
        public List<string> HolidayScheduleName
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
