using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemTrunkGroupUserCreationTaskGetListRequest14sp4.
    /// Contains a table with a row for each user creation task and column headings :
    /// "Trunk Group Name", "Group Id", "Organization Id", "Organization Type", "Name", "Status", "Users Created", "Total Users To Create", "Error Count".
    /// The "Organization Id" column is populated with either a service provider Id or an enterprise Id.
    /// The "Organization Type" column is populated with one of the enumerated strings defined in the
    /// OrganizationType OCI data type.  Please see OCISchemaDataTypes.xsd for details on OrganizationType.
    /// <see cref="SystemTrunkGroupUserCreationTaskGetListRequest14sp4"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""090e91b2d78e873f5d76a2f16af08d3a:1889""}]")]
    public class SystemTrunkGroupUserCreationTaskGetListResponse14sp4 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _taskTable;

        [XmlElement(ElementName = "taskTable", IsNullable = false, Namespace = "")]
        [Group(@"090e91b2d78e873f5d76a2f16af08d3a:1889")]
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
