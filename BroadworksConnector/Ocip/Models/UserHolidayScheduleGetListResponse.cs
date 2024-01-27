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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:45269""}]")]
    public class UserHolidayScheduleGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _holidayScheduleTable;

        [XmlElement(ElementName = "holidayScheduleTable", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:45269")]
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
        protected bool HolidayScheduleTableSpecified { get; set; }

    }
}
