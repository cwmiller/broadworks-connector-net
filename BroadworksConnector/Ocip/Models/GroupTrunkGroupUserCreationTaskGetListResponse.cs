using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupTrunkGroupUserCreationTaskGetListRequest.
    /// Contains a table with a row for each user creation task and column headings :
    /// "Name", "Status", "Users Created", "Total Users To Create", "Error Count".
        /// <see cref="GroupTrunkGroupUserCreationTaskGetListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupTrunkGroupUserCreationTaskGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.C.OCITable _taskTable;

        [XmlElement(ElementName = "taskTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable TaskTable {
            get => _taskTable;
            set {
                TaskTableSpecified = true;
                _taskTable = value;
            }
        }

        [XmlIgnore]
        public bool TaskTableSpecified { get; set; }
        
    }
}
