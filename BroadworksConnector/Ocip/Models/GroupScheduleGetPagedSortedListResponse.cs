using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupScheduleGetPagedSortedListRequest.
    /// Contains a 3 column table with column headings: "Name", "Type", "Level"
    /// and a row for each schedule.
    /// <see cref="GroupScheduleGetPagedSortedListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4b0e7857796c636464362260a2f8e5ee:7322""}]")]
    public class GroupScheduleGetPagedSortedListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _scheduleTable;

        [XmlElement(ElementName = "scheduleTable", IsNullable = false, Namespace = "")]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:7322")]
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
