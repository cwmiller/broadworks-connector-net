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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""a63afa661ee5c74f4700e562e88c66d0:839""}]")]
    public class GroupOutgoingCallingPlanTransferNumbersGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.OutgoingCallingPlanTransferNumbers _groupNumbers;

        [XmlElement(ElementName = "groupNumbers", IsNullable = false, Namespace = "")]
        [Group(@"a63afa661ee5c74f4700e562e88c66d0:839")]
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
        [Group(@"a63afa661ee5c74f4700e562e88c66d0:839")]
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
