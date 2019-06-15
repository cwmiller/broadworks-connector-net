using System;
using System.Xml.Serialization;
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
     
    public class UserTimeScheduleGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.C.OCITable _timeScheduleTable;

        [XmlElement(ElementName = "timeScheduleTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable TimeScheduleTable {
            get => _timeScheduleTable;
            set {
                TimeScheduleTableSpecified = true;
                _timeScheduleTable = value;
            }
        }

        [XmlIgnore]
        public bool TimeScheduleTableSpecified { get; set; }
        
    }
}
