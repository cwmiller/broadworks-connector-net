using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupOutgoingCallingPlanTransferNumbersGetListRequest.
    /// <see cref="GroupOutgoingCallingPlanTransferNumbersGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6f793dfca9bd3d121bb35e0f9cf1cb2e:840""}]")]
    public class GroupOutgoingCallingPlanTransferNumbersGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.OutgoingCallingPlanTransferNumbers _groupNumbers;

        [XmlElement(ElementName = "groupNumbers", IsNullable = false, Namespace = "")]
        [Group(@"6f793dfca9bd3d121bb35e0f9cf1cb2e:840")]
        public BroadWorksConnector.Ocip.Models.OutgoingCallingPlanTransferNumbers GroupNumbers
        {
            get => _groupNumbers;
            set
            {
                GroupNumbersSpecified = true;
                _groupNumbers = value;
            }
        }

        [XmlIgnore]
        protected bool GroupNumbersSpecified { get; set; }

        protected List<BroadWorksConnector.Ocip.Models.OutgoingCallingPlanDepartmentTransferNumbers> _departmentNumbers = new List<BroadWorksConnector.Ocip.Models.OutgoingCallingPlanDepartmentTransferNumbers>();

        [XmlElement(ElementName = "departmentNumbers", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6f793dfca9bd3d121bb35e0f9cf1cb2e:840")]
        public List<BroadWorksConnector.Ocip.Models.OutgoingCallingPlanDepartmentTransferNumbers> DepartmentNumbers
        {
            get => _departmentNumbers;
            set
            {
                DepartmentNumbersSpecified = true;
                _departmentNumbers = value;
            }
        }

        [XmlIgnore]
        protected bool DepartmentNumbersSpecified { get; set; }

    }
}
