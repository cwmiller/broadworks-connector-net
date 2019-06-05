using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class EnterpriseDepartmentAddRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
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
        private BroadworksConnector.Ocip.Models.EnterpriseDepartmentKey _parentDepartmentKey;

        [XmlElement(ElementName = "parentDepartmentKey", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.EnterpriseDepartmentKey ParentDepartmentKey
        {
            get => _parentDepartmentKey;
            set
            {
                ParentDepartmentKeySpecified = true;
                _parentDepartmentKey = value;
            }
        }

        [XmlIgnore]
        public bool ParentDepartmentKeySpecified { get; set; }
    }
}
