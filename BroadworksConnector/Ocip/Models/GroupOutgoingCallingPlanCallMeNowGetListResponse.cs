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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""a63afa661ee5c74f4700e562e88c66d0:156""}]")]
    public class GroupOutgoingCallingPlanCallMeNowGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.OutgoingCallingPlanCallMeNowPermissions _groupPermissions;

        [XmlElement(ElementName = "groupPermissions", IsNullable = false, Namespace = "")]
        [Group(@"a63afa661ee5c74f4700e562e88c66d0:156")]
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

        protected List<BroadWorksConnector.Ocip.Models.OutgoingCallingPlanCallMeNowDepartmentPermissions> _departmentPermissions = new List<BroadWorksConnector.Ocip.Models.OutgoingCallingPlanCallMeNowDepartmentPermissions>();

        [XmlElement(ElementName = "departmentPermissions", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"a63afa661ee5c74f4700e562e88c66d0:156")]
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
