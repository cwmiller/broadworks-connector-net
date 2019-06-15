using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get a list of enterprise level departments in an enterprise that could be the parent of the
    /// specified department. The department itself and all its decendents are not eligible to be
    /// the parent department.
    /// The response is either EnterpriseDepartmentGetAvailableParentListResponse or ErrorResponse.
        /// <see cref="EnterpriseDepartmentGetAvailableParentListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class EnterpriseDepartmentGetAvailableParentListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _enterpriseId;

        [XmlElement(ElementName = "enterpriseId", IsNullable = false, Namespace = "")]
        public string EnterpriseId {
            get => _enterpriseId;
            set {
                EnterpriseIdSpecified = true;
                _enterpriseId = value;
            }
        }

        [XmlIgnore]
        public bool EnterpriseIdSpecified { get; set; }
        
        private string _departmentName;

        [XmlElement(ElementName = "departmentName", IsNullable = false, Namespace = "")]
        public string DepartmentName {
            get => _departmentName;
            set {
                DepartmentNameSpecified = true;
                _departmentName = value;
            }
        }

        [XmlIgnore]
        public bool DepartmentNameSpecified { get; set; }
        
    }
}
