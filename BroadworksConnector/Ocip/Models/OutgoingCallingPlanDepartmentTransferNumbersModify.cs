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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6f793dfca9bd3d121bb35e0f9cf1cb2e:1848""}]")]
    public class OutgoingCallingPlanDepartmentTransferNumbersModify
    {

        protected BroadWorksConnector.Ocip.Models.DepartmentKey _departmentKey;

        [XmlElement(ElementName = "departmentKey", IsNullable = false, Namespace = "")]
        [Group(@"6f793dfca9bd3d121bb35e0f9cf1cb2e:1848")]
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
        [Group(@"6f793dfca9bd3d121bb35e0f9cf1cb2e:1848")]
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
