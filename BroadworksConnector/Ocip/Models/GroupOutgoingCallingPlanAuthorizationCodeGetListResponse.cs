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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""a63afa661ee5c74f4700e562e88c66d0:123""}]")]
    public class GroupOutgoingCallingPlanAuthorizationCodeGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.OutgoingCallingPlanGroupAuthorizationCodes _groupCodeList;

        [XmlElement(ElementName = "groupCodeList", IsNullable = false, Namespace = "")]
        [Group(@"a63afa661ee5c74f4700e562e88c66d0:123")]
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

        protected List<BroadWorksConnector.Ocip.Models.OutgoingCallingPlanDepartmentAuthorizationCodes> _departmentCodeList = new List<BroadWorksConnector.Ocip.Models.OutgoingCallingPlanDepartmentAuthorizationCodes>();

        [XmlElement(ElementName = "departmentCodeList", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"a63afa661ee5c74f4700e562e88c66d0:123")]
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
