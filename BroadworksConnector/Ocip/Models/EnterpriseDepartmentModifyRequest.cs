using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify a department of an enterprise.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""5395c7df0157d44aa22f3351d1a5f3da:740""}]")]
    public class EnterpriseDepartmentModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _enterpriseId;

        [XmlElement(ElementName = "enterpriseId", IsNullable = false, Namespace = "")]
        [Group(@"5395c7df0157d44aa22f3351d1a5f3da:740")]
        [MinLength(1)]
        [MaxLength(30)]
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
        [Group(@"5395c7df0157d44aa22f3351d1a5f3da:740")]
        [MinLength(1)]
        [MaxLength(50)]
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
        [Optional]
        [Group(@"5395c7df0157d44aa22f3351d1a5f3da:740")]
        [MinLength(1)]
        [MaxLength(50)]
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

        private BroadWorksConnector.Ocip.Models.EnterpriseDepartmentKey _newParentDepartmentKey;

        [XmlElement(ElementName = "newParentDepartmentKey", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"5395c7df0157d44aa22f3351d1a5f3da:740")]
        public BroadWorksConnector.Ocip.Models.EnterpriseDepartmentKey NewParentDepartmentKey
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
