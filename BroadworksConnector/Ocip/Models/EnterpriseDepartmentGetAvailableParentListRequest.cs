using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""5395c7df0157d44aa22f3351d1a5f3da:670""}]")]
    public class EnterpriseDepartmentGetAvailableParentListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.EnterpriseDepartmentGetAvailableParentListResponse>
    {

        private string _enterpriseId;

        [XmlElement(ElementName = "enterpriseId", IsNullable = false, Namespace = "")]
        [Group(@"5395c7df0157d44aa22f3351d1a5f3da:670")]
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
        [Group(@"5395c7df0157d44aa22f3351d1a5f3da:670")]
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

    }
}
