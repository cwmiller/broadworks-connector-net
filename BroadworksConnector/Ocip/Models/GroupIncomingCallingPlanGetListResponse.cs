using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupIncomingCallingPlanGetListRequest.
    /// <see cref="GroupIncomingCallingPlanGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""3dd296d55b56269ae23d86a934b8b35c:61""}]")]
    public class GroupIncomingCallingPlanGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.IncomingCallingPlanPermissions _groupPermissions;

        [XmlElement(ElementName = "groupPermissions", IsNullable = false, Namespace = "")]
        [Group(@"3dd296d55b56269ae23d86a934b8b35c:61")]
        public BroadWorksConnector.Ocip.Models.IncomingCallingPlanPermissions GroupPermissions
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

        private List<BroadWorksConnector.Ocip.Models.IncomingCallingPlanDepartmentPermissions> _departmentPermissions = new List<BroadWorksConnector.Ocip.Models.IncomingCallingPlanDepartmentPermissions>();

        [XmlElement(ElementName = "departmentPermissions", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3dd296d55b56269ae23d86a934b8b35c:61")]
        public List<BroadWorksConnector.Ocip.Models.IncomingCallingPlanDepartmentPermissions> DepartmentPermissions
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
