using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupOutgoingCallingPlanCallMeNowGetListRequest.
    /// <see cref="GroupOutgoingCallingPlanCallMeNowGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6f793dfca9bd3d121bb35e0f9cf1cb2e:157""}]")]
    public class GroupOutgoingCallingPlanCallMeNowGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.OutgoingCallingPlanCallMeNowPermissions _groupPermissions;

        [XmlElement(ElementName = "groupPermissions", IsNullable = false, Namespace = "")]
        [Group(@"6f793dfca9bd3d121bb35e0f9cf1cb2e:157")]
        public BroadWorksConnector.Ocip.Models.OutgoingCallingPlanCallMeNowPermissions GroupPermissions
        {
            get => _groupPermissions;
            set
            {
                GroupPermissionsSpecified = true;
                _groupPermissions = value;
            }
        }

        [XmlIgnore]
        protected bool GroupPermissionsSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.OutgoingCallingPlanCallMeNowDepartmentPermissions> _departmentPermissions = new List<BroadWorksConnector.Ocip.Models.OutgoingCallingPlanCallMeNowDepartmentPermissions>();

        [XmlElement(ElementName = "departmentPermissions", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6f793dfca9bd3d121bb35e0f9cf1cb2e:157")]
        public List<BroadWorksConnector.Ocip.Models.OutgoingCallingPlanCallMeNowDepartmentPermissions> DepartmentPermissions
        {
            get => _departmentPermissions;
            set
            {
                DepartmentPermissionsSpecified = true;
                _departmentPermissions = value;
            }
        }

        [XmlIgnore]
        protected bool DepartmentPermissionsSpecified { get; set; }

    }
}
