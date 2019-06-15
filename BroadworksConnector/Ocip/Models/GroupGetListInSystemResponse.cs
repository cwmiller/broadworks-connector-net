using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupGetListInSystemRequest.
    /// Contains a table with column headings: "Group Id", "Group Name", "User Limit", "Organization Id", "Organization Type", "Reseller Id"
    /// and a row for each group.
    /// The "Organization Id" column is populated with either a service provider Id or an enterprise Id.
    /// The "Organization Type" column is populated with one of the enumerated strings defined in the
    /// OrganizationType OCI data type.  Please see OCISchemaDataTypes.xsd for details on OrganizationType.
    /// 
    /// The following columns are only returned in AS data mode:
    /// Reseller Id
        /// <see cref="GroupGetListInSystemRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupGetListInSystemResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.C.OCITable _groupTable;

        [XmlElement(ElementName = "groupTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable GroupTable {
            get => _groupTable;
            set {
                GroupTableSpecified = true;
                _groupTable = value;
            }
        }

        [XmlIgnore]
        public bool GroupTableSpecified { get; set; }
        
    }
}
