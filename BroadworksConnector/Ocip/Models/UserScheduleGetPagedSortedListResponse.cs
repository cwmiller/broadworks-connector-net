using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserScheduleGetPagedSortedListRequest.
    /// Contains a 3 column table with column headings: "Name", "Type", "Level"
    /// and a row for each schedule.
    /// <see cref="UserScheduleGetPagedSortedListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""fb73488c2ef4ac4400ab213b637d79a9:3788""}]")]
    public class UserScheduleGetPagedSortedListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _scheduleTable;

        [XmlElement(ElementName = "scheduleTable", IsNullable = false, Namespace = "")]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:3788")]
        public BroadWorksConnector.Ocip.Models.C.OCITable ScheduleTable
        {
            get => _scheduleTable;
            set
            {
                ScheduleTableSpecified = true;
                _scheduleTable = value;
            }
        }

        [XmlIgnore]
        protected bool ScheduleTableSpecified { get; set; }

    }
}
