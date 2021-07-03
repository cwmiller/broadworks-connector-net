using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Outgoing Calling Plan originating call permissions for a department.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6f793dfca9bd3d121bb35e0f9cf1cb2e:2015""}]")]
    public class OutgoingCallingPlanOriginatingDepartmentPermissions
    {

        private BroadWorksConnector.Ocip.Models.DepartmentKey _departmentKey;

        [XmlElement(ElementName = "departmentKey", IsNullable = false, Namespace = "")]
        [Group(@"6f793dfca9bd3d121bb35e0f9cf1cb2e:2015")]
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

        private string _departmentName;

        [XmlElement(ElementName = "departmentName", IsNullable = false, Namespace = "")]
        [Group(@"6f793dfca9bd3d121bb35e0f9cf1cb2e:2015")]
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
        protected bool DepartmentNameSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.OutgoingCallingPlanOriginatingPermissions _permissions;

        [XmlElement(ElementName = "permissions", IsNullable = false, Namespace = "")]
        [Group(@"6f793dfca9bd3d121bb35e0f9cf1cb2e:2015")]
        public BroadWorksConnector.Ocip.Models.OutgoingCallingPlanOriginatingPermissions Permissions
        {
            get => _permissions;
            set
            {
                PermissionsSpecified = true;
                _permissions = value;
            }
        }

        [XmlIgnore]
        protected bool PermissionsSpecified { get; set; }

    }
}
