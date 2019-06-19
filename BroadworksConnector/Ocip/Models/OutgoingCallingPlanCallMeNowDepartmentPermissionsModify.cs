using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify outgoing Calling Plan for Call Me Now call permissions for a department.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6f793dfca9bd3d121bb35e0f9cf1cb2e:1761""}]")]
    public class OutgoingCallingPlanCallMeNowDepartmentPermissionsModify
    {

        private BroadWorksConnector.Ocip.Models.DepartmentKey _departmentKey;

        [XmlElement(ElementName = "departmentKey", IsNullable = false, Namespace = "")]
        [Group(@"6f793dfca9bd3d121bb35e0f9cf1cb2e:1761")]
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

        private BroadWorksConnector.Ocip.Models.OutgoingCallingPlanCallMeNowPermissionsModify _permissions;

        [XmlElement(ElementName = "permissions", IsNullable = false, Namespace = "")]
        [Group(@"6f793dfca9bd3d121bb35e0f9cf1cb2e:1761")]
        public BroadWorksConnector.Ocip.Models.OutgoingCallingPlanCallMeNowPermissionsModify Permissions
        {
            get => _permissions;
            set
            {
                PermissionsSpecified = true;
                _permissions = value;
            }
        }

        [XmlIgnore]
        public bool PermissionsSpecified { get; set; }

    }
}
