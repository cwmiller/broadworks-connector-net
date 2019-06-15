using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserServiceGetAssignmentListRequest.
    /// Contains two tables, one for the service packs, and one for the user services.
    /// The user table has the column headings: "Service Name", "Assigned",
    /// The service pack table's column headings are: "Service Pack Name", "Assigned", "Description".
    /// The "Assigned" column has either a true or false value
        /// <see cref="UserServiceGetAssignmentListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserServiceGetAssignmentListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.C.OCITable _servicePacksAssignmentTable;

        [XmlElement(ElementName = "servicePacksAssignmentTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable ServicePacksAssignmentTable {
            get => _servicePacksAssignmentTable;
            set {
                ServicePacksAssignmentTableSpecified = true;
                _servicePacksAssignmentTable = value;
            }
        }

        [XmlIgnore]
        public bool ServicePacksAssignmentTableSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.C.OCITable _userServicesAssignmentTable;

        [XmlElement(ElementName = "userServicesAssignmentTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable UserServicesAssignmentTable {
            get => _userServicesAssignmentTable;
            set {
                UserServicesAssignmentTableSpecified = true;
                _userServicesAssignmentTable = value;
            }
        }

        [XmlIgnore]
        public bool UserServicesAssignmentTableSpecified { get; set; }
        
    }
}
