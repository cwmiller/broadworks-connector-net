using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemTrunkGroupUserCreationTaskGetListRequest.
    /// Contains a table with a row for each user creation task and column headings :
    /// "Service User Id", "Group Id", "Organization Id", "Organization Type", "Name", "Status", "Users
    /// Created", "Total Users To Create", "Error Count".
    /// The "Organization Id" column is populated with either a service provider Id or an enterprise Id.
    /// The "Organization Type" column is populated with one of the enumerated strings defined in the
    /// OrganizationType OCI data type. Please see OCISchemaDataTypes.xsd for details on OrganizationType.
        /// <see cref="SystemTrunkGroupUserCreationTaskGetListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemTrunkGroupUserCreationTaskGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
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
