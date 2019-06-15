using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupDepartmentAdminGetListRequest.
    /// Contains a 5 column table with column headings "Administrator ID",
    /// "Last Name", "First Name", "Department", "Language".
        /// <see cref="GroupDepartmentAdminGetListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupDepartmentAdminGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.C.OCITable _departmentAdminTable;

        [XmlElement(ElementName = "departmentAdminTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable DepartmentAdminTable {
            get => _departmentAdminTable;
            set {
                DepartmentAdminTableSpecified = true;
                _departmentAdminTable = value;
            }
        }

        [XmlIgnore]
        public bool DepartmentAdminTableSpecified { get; set; }
        
    }
}
