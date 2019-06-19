using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupOutgoingCallingPlanPinholeDigitPlanOriginatingGetListRequest.
    /// <see cref="GroupOutgoingCallingPlanPinholeDigitPlanOriginatingGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6f793dfca9bd3d121bb35e0f9cf1cb2e:631""}]")]
    public class GroupOutgoingCallingPlanPinholeDigitPlanOriginatingGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.OutgoingPinholeDigitPlanDigitPatternOriginatingPermissions _groupPermissions;

        [XmlElement(ElementName = "groupPermissions", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6f793dfca9bd3d121bb35e0f9cf1cb2e:631")]
        public BroadWorksConnector.Ocip.Models.OutgoingPinholeDigitPlanDigitPatternOriginatingPermissions GroupPermissions
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

        private List<BroadWorksConnector.Ocip.Models.OutgoingPinholeDigitPlanDigitPatternOriginatingDepartmentPermissions> _departmentPermissions = new List<BroadWorksConnector.Ocip.Models.OutgoingPinholeDigitPlanDigitPatternOriginatingDepartmentPermissions>();

        [XmlElement(ElementName = "departmentPermissions", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6f793dfca9bd3d121bb35e0f9cf1cb2e:631")]
        public List<BroadWorksConnector.Ocip.Models.OutgoingPinholeDigitPlanDigitPatternOriginatingDepartmentPermissions> DepartmentPermissions
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
