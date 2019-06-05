using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class EnterpriseDepartmentGetListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
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
        private bool _includeGroupDepartments;

        [XmlElement(ElementName = "includeGroupDepartments", IsNullable = false, Namespace = "")]
        public bool IncludeGroupDepartments
        {
            get => _includeGroupDepartments;
            set
            {
                IncludeGroupDepartmentsSpecified = true;
                _includeGroupDepartments = value;
            }
        }

        [XmlIgnore]
        public bool IncludeGroupDepartmentsSpecified { get; set; }
    }
}
