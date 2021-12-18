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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f3a93cf15de4abd7903673e44ee3e07b:7585""}]")]
    public class GroupScheduleGetPagedSortedListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _scheduleTable;

        [XmlElement(ElementName = "scheduleTable", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:7585")]
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
