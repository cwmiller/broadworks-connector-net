using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupOutgoingCallingPlanDigitPlanCallMeNowGetListRequest.
        /// <see cref="GroupOutgoingCallingPlanDigitPlanCallMeNowGetListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupOutgoingCallingPlanDigitPlanCallMeNowGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.OutgoingCallingPlanDigitPatternCallMeNowPermissions _groupPermissions;

        [XmlElement(ElementName = "groupPermissions", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.OutgoingCallingPlanDigitPatternCallMeNowPermissions GroupPermissions {
            get => _groupPermissions;
            set {
                GroupPermissionsSpecified = true;
                _groupPermissions = value;
            }
        }

        [XmlIgnore]
        public bool GroupPermissionsSpecified { get; set; }
        
        private List<BroadWorksConnector.Ocip.Models.OutgoingCallingPlanDigitPatternCallMeNowDepartmentPermissions> _departmentPermissions;

        [XmlElement(ElementName = "departmentPermissions", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.OutgoingCallingPlanDigitPatternCallMeNowDepartmentPermissions> DepartmentPermissions {
            get => _departmentPermissions;
            set {
                DepartmentPermissionsSpecified = true;
                _departmentPermissions = value;
            }
        }

        [XmlIgnore]
        public bool DepartmentPermissionsSpecified { get; set; }
        
    }
}
