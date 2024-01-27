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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""090e91b2d78e873f5d76a2f16af08d3a:1550""}]")]
    public class GroupTrunkGroupUserCreationTaskGetListResponse14sp4 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _taskTable;

        [XmlElement(ElementName = "taskTable", IsNullable = false, Namespace = "")]
        [Group(@"090e91b2d78e873f5d76a2f16af08d3a:1550")]
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
        protected bool TaskTableSpecified { get; set; }

    }
}
