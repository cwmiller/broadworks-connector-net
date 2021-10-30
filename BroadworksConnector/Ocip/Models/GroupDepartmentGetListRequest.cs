using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request a list of departments in a group. You may request only the
    /// list of departments defined at the group-level, or you may request
    /// the list of all departments in the group including all the departments
    /// defined within the enterprise the group belongs to.
    /// The response is either GroupDepartmentGetListResponse or ErrorResponse.
    /// 
    /// Replaced by: GroupDepartmentGetListRequest18
    /// <see cref="GroupDepartmentGetListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="GroupDepartmentGetListRequest18"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:9041""}]")]
    public class GroupDepartmentGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.GroupDepartmentGetListResponse>
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:9041")]
        [MinLength(1)]
        [MaxLength(30)]
        public string ServiceProviderId
        {
            get => _serviceProviderId;
            set
            {
                ServiceProviderIdSpecified = true;
                _serviceProviderId = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceProviderIdSpecified { get; set; }

        private string _groupId;

        [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:9041")]
        [MinLength(1)]
        [MaxLength(30)]
        public string GroupId
        {
            get => _groupId;
            set
            {
                GroupIdSpecified = true;
                _groupId = value;
            }
        }

        [XmlIgnore]
        protected bool GroupIdSpecified { get; set; }

        private bool _includeEnterpriseDepartments;

        [XmlElement(ElementName = "includeEnterpriseDepartments", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:9041")]
        public bool IncludeEnterpriseDepartments
        {
            get => _includeEnterpriseDepartments;
            set
            {
                IncludeEnterpriseDepartmentsSpecified = true;
                _includeEnterpriseDepartments = value;
            }
        }

        [XmlIgnore]
        protected bool IncludeEnterpriseDepartmentsSpecified { get; set; }

    }
}
