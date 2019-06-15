using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the Call Me Now call permissions for digit patterns for a group default and it's departments.
    /// The response is either a SuccessResponse or an ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupOutgoingCallingPlanDigitPlanCallMeNowModifyListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        public string ServiceProviderId {
            get => _serviceProviderId;
            set {
                ServiceProviderIdSpecified = true;
                _serviceProviderId = value;
            }
        }

        [XmlIgnore]
        public bool ServiceProviderIdSpecified { get; set; }
        
        private string _groupId;

        [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
        public string GroupId {
            get => _groupId;
            set {
                GroupIdSpecified = true;
                _groupId = value;
            }
        }

        [XmlIgnore]
        public bool GroupIdSpecified { get; set; }
        
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
        
        private List<BroadWorksConnector.Ocip.Models.OutgoingCallingPlanDigitPatternCallMeNowDepartmentPermissionsModify> _departmentPermissions;

        [XmlElement(ElementName = "departmentPermissions", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.OutgoingCallingPlanDigitPatternCallMeNowDepartmentPermissionsModify> DepartmentPermissions {
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
