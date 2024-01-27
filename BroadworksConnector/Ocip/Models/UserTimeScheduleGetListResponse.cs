using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the UserTimeScheduleGetListRequest. The column headings are "Time Schedule" and
    /// "Type".
    /// The response contains user's personal and user's group's schedule names.
    /// <see cref="UserTimeScheduleGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:47656""}]")]
    public class UserTimeScheduleGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _timeScheduleTable;

        [XmlElement(ElementName = "timeScheduleTable", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:47656")]
        public BroadWorksConnector.Ocip.Models.C.OCITable TimeScheduleTable
        {
            get => _timeScheduleTable;
            set
            {
                TimeScheduleTableSpecified = true;
                _timeScheduleTable = value;
            }
        }

        [XmlIgnore]
        protected bool TimeScheduleTableSpecified { get; set; }

    }
}
