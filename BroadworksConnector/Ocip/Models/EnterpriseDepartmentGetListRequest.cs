using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request a list of departments in an enterprise. You may request only the
    /// list of departments defined at the enterprise-level, or you may request
    /// the list of all departments in the enterprise including all the departments
    /// defined within the groups inside the enterprise.
    /// The response is either EnterpriseDepartmentGetListResponse or ErrorResponse.
    /// <see cref="EnterpriseDepartmentGetListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""5395c7df0157d44aa22f3351d1a5f3da:707""}]")]
    public class EnterpriseDepartmentGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.EnterpriseDepartmentGetListResponse>
    {

        private string _enterpriseId;

        [XmlElement(ElementName = "enterpriseId", IsNullable = false, Namespace = "")]
        [Group(@"5395c7df0157d44aa22f3351d1a5f3da:707")]
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

        private bool _includeGroupDepartments;

        [XmlElement(ElementName = "includeGroupDepartments", IsNullable = false, Namespace = "")]
        [Group(@"5395c7df0157d44aa22f3351d1a5f3da:707")]
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
        protected bool IncludeGroupDepartmentsSpecified { get; set; }

    }
}
