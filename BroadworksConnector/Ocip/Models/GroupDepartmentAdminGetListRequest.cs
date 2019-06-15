using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get a list of department administrators for the department.
    /// The response is either a GroupDepartmentAdminGetListResponse or an ErrorResponse.
        /// <see cref="GroupDepartmentAdminGetListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupDepartmentAdminGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private BroadWorksConnector.Ocip.Models.GroupDepartmentKey _departmentKey;

        [XmlElement(ElementName = "departmentKey", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.GroupDepartmentKey DepartmentKey {
            get => _departmentKey;
            set {
                DepartmentKeySpecified = true;
                _departmentKey = value;
            }
        }

        [XmlIgnore]
        public bool DepartmentKeySpecified { get; set; }
        
    }
}
