using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Add a department to enterprise.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""5395c7df0157d44aa22f3351d1a5f3da:632""}]")]
    public class EnterpriseDepartmentAddRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _enterpriseId;

        [XmlElement(ElementName = "enterpriseId", IsNullable = false, Namespace = "")]
        [Group(@"5395c7df0157d44aa22f3351d1a5f3da:632")]
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
        protected bool EnterpriseIdSpecified { get; set; }

        private string _departmentName;

        [XmlElement(ElementName = "departmentName", IsNullable = false, Namespace = "")]
        [Group(@"5395c7df0157d44aa22f3351d1a5f3da:632")]
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
        protected bool DepartmentNameSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.EnterpriseDepartmentKey _parentDepartmentKey;

        [XmlElement(ElementName = "parentDepartmentKey", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"5395c7df0157d44aa22f3351d1a5f3da:632")]
        public BroadWorksConnector.Ocip.Models.EnterpriseDepartmentKey ParentDepartmentKey
        {
            get => _parentDepartmentKey;
            set
            {
                ParentDepartmentKeySpecified = true;
                _parentDepartmentKey = value;
            }
        }

        [XmlIgnore]
        protected bool ParentDepartmentKeySpecified { get; set; }

    }
}
