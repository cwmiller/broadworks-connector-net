using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupOutgoingCallingPlanAuthorizationCodeGetListRequest.
    /// <see cref="GroupOutgoingCallingPlanAuthorizationCodeGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6f793dfca9bd3d121bb35e0f9cf1cb2e:124""}]")]
    public class GroupOutgoingCallingPlanAuthorizationCodeGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.OutgoingCallingPlanGroupAuthorizationCodes _groupCodeList;

        [XmlElement(ElementName = "groupCodeList", IsNullable = false, Namespace = "")]
        [Group(@"6f793dfca9bd3d121bb35e0f9cf1cb2e:124")]
        public BroadWorksConnector.Ocip.Models.OutgoingCallingPlanGroupAuthorizationCodes GroupCodeList
        {
            get => _groupCodeList;
            set
            {
                GroupCodeListSpecified = true;
                _groupCodeList = value;
            }
        }

        [XmlIgnore]
        protected bool GroupCodeListSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.OutgoingCallingPlanDepartmentAuthorizationCodes> _departmentCodeList = new List<BroadWorksConnector.Ocip.Models.OutgoingCallingPlanDepartmentAuthorizationCodes>();

        [XmlElement(ElementName = "departmentCodeList", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6f793dfca9bd3d121bb35e0f9cf1cb2e:124")]
        public List<BroadWorksConnector.Ocip.Models.OutgoingCallingPlanDepartmentAuthorizationCodes> DepartmentCodeList
        {
            get => _departmentCodeList;
            set
            {
                DepartmentCodeListSpecified = true;
                _departmentCodeList = value;
            }
        }

        [XmlIgnore]
        protected bool DepartmentCodeListSpecified { get; set; }

    }
}
