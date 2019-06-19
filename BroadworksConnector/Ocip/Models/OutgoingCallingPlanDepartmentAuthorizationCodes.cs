using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Outgoing Calling Plan Authorization Code for a department.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6f793dfca9bd3d121bb35e0f9cf1cb2e:1821""}]")]
    public class OutgoingCallingPlanDepartmentAuthorizationCodes
    {

        private BroadWorksConnector.Ocip.Models.DepartmentKey _departmentKey;

        [XmlElement(ElementName = "departmentKey", IsNullable = false, Namespace = "")]
        [Group(@"6f793dfca9bd3d121bb35e0f9cf1cb2e:1821")]
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
        public bool DepartmentKeySpecified { get; set; }

        private string _departmentName;

        [XmlElement(ElementName = "departmentName", IsNullable = false, Namespace = "")]
        [Group(@"6f793dfca9bd3d121bb35e0f9cf1cb2e:1821")]
        [MinLength(1)]
        public string DepartmentName
        {
            get => _departmentName;
            set
            {
                DepartmentNameSpecified = true;
                _departmentName = value;
            }
        }

        [XmlIgnore]
        public bool DepartmentNameSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.OutgoingCallingPlanAuthorizationCodeEntry> _codeEntry = new List<BroadWorksConnector.Ocip.Models.OutgoingCallingPlanAuthorizationCodeEntry>();

        [XmlElement(ElementName = "codeEntry", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6f793dfca9bd3d121bb35e0f9cf1cb2e:1821")]
        public List<BroadWorksConnector.Ocip.Models.OutgoingCallingPlanAuthorizationCodeEntry> CodeEntry
        {
            get => _codeEntry;
            set
            {
                CodeEntrySpecified = true;
                _codeEntry = value;
            }
        }

        [XmlIgnore]
        public bool CodeEntrySpecified { get; set; }

    }
}
