using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Outgoing Calling Plan transfer numbers for a department.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""a63afa661ee5c74f4700e562e88c66d0:1847""}]")]
    public class OutgoingCallingPlanDepartmentTransferNumbersModify
    {

        protected BroadWorksConnector.Ocip.Models.DepartmentKey _departmentKey;

        [XmlElement(ElementName = "departmentKey", IsNullable = false, Namespace = "")]
        [Group(@"a63afa661ee5c74f4700e562e88c66d0:1847")]
        public BroadWorksConnector.Ocip.Models.DepartmentKey DepartmentKey
        {
            get => _departmentKey;
            set
            {
                DepartmentKeySpecified = true;
                _departmentKey = value;
            }
        }

        [XmlIgnore]
        protected bool DepartmentKeySpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.OutgoingCallingPlanTransferNumbersModify _transferNumbers;

        [XmlElement(ElementName = "transferNumbers", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"a63afa661ee5c74f4700e562e88c66d0:1847")]
        public BroadWorksConnector.Ocip.Models.OutgoingCallingPlanTransferNumbersModify TransferNumbers
        {
            get => _transferNumbers;
            set
            {
                TransferNumbersSpecified = true;
                _transferNumbers = value;
            }
        }

        [XmlIgnore]
        protected bool TransferNumbersSpecified { get; set; }

    }
}
