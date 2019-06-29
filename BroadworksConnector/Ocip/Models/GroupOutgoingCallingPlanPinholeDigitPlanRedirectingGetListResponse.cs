using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupOutgoingCallingPlanPinholeDigitPlanRedirectingGetListRequest.
    /// <see cref="GroupOutgoingCallingPlanPinholeDigitPlanRedirectingGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6f793dfca9bd3d121bb35e0f9cf1cb2e:683""}]")]
    public class GroupOutgoingCallingPlanPinholeDigitPlanRedirectingGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.OutgoingPinholeDigitPlanDigitPatternRedirectingPermissions _groupPermissions;

        [XmlElement(ElementName = "groupPermissions", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6f793dfca9bd3d121bb35e0f9cf1cb2e:683")]
        public BroadWorksConnector.Ocip.Models.OutgoingPinholeDigitPlanDigitPatternRedirectingPermissions GroupPermissions
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

        private List<BroadWorksConnector.Ocip.Models.OutgoingPinholeDigitPlanDigitPatternRedirectingDepartmentPermissions> _departmentPermissions = new List<BroadWorksConnector.Ocip.Models.OutgoingPinholeDigitPlanDigitPatternRedirectingDepartmentPermissions>();

        [XmlElement(ElementName = "departmentPermissions", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6f793dfca9bd3d121bb35e0f9cf1cb2e:683")]
        public List<BroadWorksConnector.Ocip.Models.OutgoingPinholeDigitPlanDigitPatternRedirectingDepartmentPermissions> DepartmentPermissions
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
