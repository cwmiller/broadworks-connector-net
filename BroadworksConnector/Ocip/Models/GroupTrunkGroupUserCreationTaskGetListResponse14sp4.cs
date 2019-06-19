using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupTrunkGroupUserCreationTaskGetListRequest14sp4.
    /// Contains a table with a row for each user creation task and column headings :
    /// "Name", "Status", "Users Created", "Total Users To Create", "Error Count".
    /// <see cref="GroupTrunkGroupUserCreationTaskGetListRequest14sp4"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""b9c14e2d80e4e7749688ca13ba233b44:1528""}]")]
    public class GroupTrunkGroupUserCreationTaskGetListResponse14sp4 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _taskTable;

        [XmlElement(ElementName = "taskTable", IsNullable = false, Namespace = "")]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:1528")]
        public BroadWorksConnector.Ocip.Models.C.OCITable TaskTable
        {
            get => _taskTable;
            set
            {
                TaskTableSpecified = true;
                _taskTable = value;
            }
        }

        [XmlIgnore]
        public bool TaskTableSpecified { get; set; }

    }
}
