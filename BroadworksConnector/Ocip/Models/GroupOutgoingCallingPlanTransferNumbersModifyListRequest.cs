using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the list of transfer numbers for a group default and it's departments.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6f793dfca9bd3d121bb35e0f9cf1cb2e:856""}]")]
    public class GroupOutgoingCallingPlanTransferNumbersModifyListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"6f793dfca9bd3d121bb35e0f9cf1cb2e:856")]
        [MinLength(1)]
        [MaxLength(30)]
        public string ServiceProviderId
        {
            get => _serviceProviderId;
            set
            {
                ServiceProviderIdSpecified = true;
                _serviceProviderId = value;
            }
        }

        [XmlIgnore]
        public bool ServiceProviderIdSpecified { get; set; }

        private string _groupId;

        [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
        [Group(@"6f793dfca9bd3d121bb35e0f9cf1cb2e:856")]
        [MinLength(1)]
        [MaxLength(30)]
        public string GroupId
        {
            get => _groupId;
            set
            {
                GroupIdSpecified = true;
                _groupId = value;
            }
        }

        [XmlIgnore]
        public bool GroupIdSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.OutgoingCallingPlanTransferNumbersModify _groupNumbers;

        [XmlElement(ElementName = "groupNumbers", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6f793dfca9bd3d121bb35e0f9cf1cb2e:856")]
        public BroadWorksConnector.Ocip.Models.OutgoingCallingPlanTransferNumbersModify GroupNumbers
        {
            get => _groupNumbers;
            set
            {
                GroupNumbersSpecified = true;
                _groupNumbers = value;
            }
        }

        [XmlIgnore]
        public bool GroupNumbersSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.OutgoingCallingPlanDepartmentTransferNumbersModify> _departmentNumbers = new List<BroadWorksConnector.Ocip.Models.OutgoingCallingPlanDepartmentTransferNumbersModify>();

        [XmlElement(ElementName = "departmentNumbers", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6f793dfca9bd3d121bb35e0f9cf1cb2e:856")]
        public List<BroadWorksConnector.Ocip.Models.OutgoingCallingPlanDepartmentTransferNumbersModify> DepartmentNumbers
        {
            get => _departmentNumbers;
            set
            {
                DepartmentNumbersSpecified = true;
                _departmentNumbers = value;
            }
        }

        [XmlIgnore]
        public bool DepartmentNumbersSpecified { get; set; }

    }
}
