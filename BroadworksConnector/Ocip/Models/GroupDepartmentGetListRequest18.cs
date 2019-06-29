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
    /// The response is either GroupDepartmentGetListResponse18 or ErrorResponse.
    /// <see cref="GroupDepartmentGetListResponse18"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f3a93cf15de4abd7903673e44ee3e07b:3147""}]")]
    public class GroupDepartmentGetListRequest18 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:3147")]
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
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:3147")]
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
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:3147")]
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
