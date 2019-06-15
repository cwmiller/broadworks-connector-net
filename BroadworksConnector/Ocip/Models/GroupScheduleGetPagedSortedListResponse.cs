using System;
using System.Xml.Serialization;
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
     
    public class GroupScheduleGetPagedSortedListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.C.OCITable _scheduleTable;

        [XmlElement(ElementName = "scheduleTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable ScheduleTable {
            get => _scheduleTable;
            set {
                ScheduleTableSpecified = true;
                _scheduleTable = value;
            }
        }

        [XmlIgnore]
        public bool ScheduleTableSpecified { get; set; }
        
    }
}
