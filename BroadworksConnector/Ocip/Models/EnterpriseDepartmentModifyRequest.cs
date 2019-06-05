using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class EnterpriseDepartmentModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
    {
        private string _enterpriseId;

        [XmlElement(ElementName = "enterpriseId", IsNullable = false, Namespace = "")]
        public string EnterpriseId
        {
            get => _enterpriseId;
            set
            {
                EnterpriseIdSpecified = true;
                _enterpriseId = value;
            }
        }

        [XmlIgnore]
        public bool EnterpriseIdSpecified { get; set; }
        private string _departmentName;

        [XmlElement(ElementName = "departmentName", IsNullable = false, Namespace = "")]
        public string DepartmentName
        {
            get => _departmentName;
            set
            {
                DepartmentNameSpecified = true;
                _departmentName = value;
            }
        }

        [XmlIgnore]
        public bool DepartmentNameSpecified { get; set; }
        private string _newDepartmentName;

        [XmlElement(ElementName = "newDepartmentName", IsNullable = false, Namespace = "")]
        public string NewDepartmentName
        {
            get => _newDepartmentName;
            set
            {
                NewDepartmentNameSpecified = true;
                _newDepartmentName = value;
            }
        }

        [XmlIgnore]
        public bool NewDepartmentNameSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.EnterpriseDepartmentKey _newParentDepartmentKey;

        [XmlElement(ElementName = "newParentDepartmentKey", IsNullable = true, Namespace = "")]
        public BroadworksConnector.Ocip.Models.EnterpriseDepartmentKey NewParentDepartmentKey
        {
            get => _newParentDepartmentKey;
            set
            {
                NewParentDepartmentKeySpecified = true;
                _newParentDepartmentKey = value;
            }
        }

        [XmlIgnore]
        public bool NewParentDepartmentKeySpecified { get; set; }
    }
}
