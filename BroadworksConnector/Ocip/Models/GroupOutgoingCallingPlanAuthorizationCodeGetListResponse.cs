using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupOutgoingCallingPlanAuthorizationCodeGetListRequest.
        /// <see cref="GroupOutgoingCallingPlanAuthorizationCodeGetListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupOutgoingCallingPlanAuthorizationCodeGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.OutgoingCallingPlanGroupAuthorizationCodes _groupCodeList;

        [XmlElement(ElementName = "groupCodeList", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.OutgoingCallingPlanGroupAuthorizationCodes GroupCodeList {
            get => _groupCodeList;
            set {
                GroupCodeListSpecified = true;
                _groupCodeList = value;
            }
        }

        [XmlIgnore]
        public bool GroupCodeListSpecified { get; set; }
        
        private List<BroadWorksConnector.Ocip.Models.OutgoingCallingPlanDepartmentAuthorizationCodes> _departmentCodeList;

        [XmlElement(ElementName = "departmentCodeList", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.OutgoingCallingPlanDepartmentAuthorizationCodes> DepartmentCodeList {
            get => _departmentCodeList;
            set {
                DepartmentCodeListSpecified = true;
                _departmentCodeList = value;
            }
        }

        [XmlIgnore]
        public bool DepartmentCodeListSpecified { get; set; }
        
    }
}
