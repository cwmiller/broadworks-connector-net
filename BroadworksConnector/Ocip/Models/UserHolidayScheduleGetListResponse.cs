using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the UserHolidayScheduleGetListRequest.
    /// The response contains all the user's personal and user's group holiday schedule names.
    /// <see cref="UserHolidayScheduleGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:17289""}]")]
    public class UserHolidayScheduleGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _holidayScheduleTable;

        [XmlElement(ElementName = "holidayScheduleTable", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:17289")]
        public BroadWorksConnector.Ocip.Models.C.OCITable HolidayScheduleTable
        {
            get => _holidayScheduleTable;
            set
            {
                HolidayScheduleTableSpecified = true;
                _holidayScheduleTable = value;
            }
        }

        [XmlIgnore]
        public bool HolidayScheduleTableSpecified { get; set; }

    }
}
