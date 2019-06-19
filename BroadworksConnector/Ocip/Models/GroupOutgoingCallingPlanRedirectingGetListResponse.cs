using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupOutgoingCallingPlanRedirectingGetListRequest.
    /// <see cref="GroupOutgoingCallingPlanRedirectingGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6f793dfca9bd3d121bb35e0f9cf1cb2e:787""}]")]
    public class GroupOutgoingCallingPlanRedirectingGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.OutgoingCallingPlanRedirectingPermissions _groupPermissions;

        [XmlElement(ElementName = "groupPermissions", IsNullable = false, Namespace = "")]
        [Group(@"6f793dfca9bd3d121bb35e0f9cf1cb2e:787")]
        public BroadWorksConnector.Ocip.Models.OutgoingCallingPlanRedirectingPermissions GroupPermissions
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

        private List<BroadWorksConnector.Ocip.Models.OutgoingCallingPlanRedirectingDepartmentPermissions> _departmentPermissions = new List<BroadWorksConnector.Ocip.Models.OutgoingCallingPlanRedirectingDepartmentPermissions>();

        [XmlElement(ElementName = "departmentPermissions", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6f793dfca9bd3d121bb35e0f9cf1cb2e:787")]
        public List<BroadWorksConnector.Ocip.Models.OutgoingCallingPlanRedirectingDepartmentPermissions> DepartmentPermissions
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
