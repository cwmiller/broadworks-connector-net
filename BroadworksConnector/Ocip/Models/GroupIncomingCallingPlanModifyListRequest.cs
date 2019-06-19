using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Change the group's incoming calling plan settings.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""3dd296d55b56269ae23d86a934b8b35c:78""}]")]
    public class GroupIncomingCallingPlanModifyListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"3dd296d55b56269ae23d86a934b8b35c:78")]
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
        public bool ServiceProviderIdSpecified { get; set; }

        private string _groupId;

        [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
        [Group(@"3dd296d55b56269ae23d86a934b8b35c:78")]
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
        public bool GroupIdSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.IncomingCallingPlanPermissionsModify _groupPermissions;

        [XmlElement(ElementName = "groupPermissions", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3dd296d55b56269ae23d86a934b8b35c:78")]
        public BroadWorksConnector.Ocip.Models.IncomingCallingPlanPermissionsModify GroupPermissions
        {
            get => _groupPermissions;
            set
            {
                GroupPermissionsSpecified = true;
                _groupPermissions = value;
            }
        }

        [XmlIgnore]
        public bool GroupPermissionsSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.IncomingCallingPlanDepartmentPermissionsModify> _departmentPermissions = new List<BroadWorksConnector.Ocip.Models.IncomingCallingPlanDepartmentPermissionsModify>();

        [XmlElement(ElementName = "departmentPermissions", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3dd296d55b56269ae23d86a934b8b35c:78")]
        public List<BroadWorksConnector.Ocip.Models.IncomingCallingPlanDepartmentPermissionsModify> DepartmentPermissions
        {
            get => _departmentPermissions;
            set
            {
                DepartmentPermissionsSpecified = true;
                _departmentPermissions = value;
            }
        }

        [XmlIgnore]
        public bool DepartmentPermissionsSpecified { get; set; }

    }
}
