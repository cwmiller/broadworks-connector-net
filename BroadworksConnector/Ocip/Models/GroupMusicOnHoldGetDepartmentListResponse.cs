using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupMusicOnHoldGetDepartmentListRequest.
    /// <see cref="GroupMusicOnHoldGetDepartmentListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""66fe518a637c74cc4b2c97aa7f68fc49:110""}]")]
    public class GroupMusicOnHoldGetDepartmentListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _hasDepartment;

        [XmlElement(ElementName = "hasDepartment", IsNullable = false, Namespace = "")]
        [Group(@"66fe518a637c74cc4b2c97aa7f68fc49:110")]
        public bool HasDepartment
        {
            get => _hasDepartment;
            set
            {
                HasDepartmentSpecified = true;
                _hasDepartment = value;
            }
        }

        [XmlIgnore]
        public bool HasDepartmentSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.DepartmentKey> _department = new List<BroadWorksConnector.Ocip.Models.DepartmentKey>();

        [XmlElement(ElementName = "department", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"66fe518a637c74cc4b2c97aa7f68fc49:110")]
        public List<BroadWorksConnector.Ocip.Models.DepartmentKey> Department
        {
            get => _department;
            set
            {
                DepartmentSpecified = true;
                _department = value;
            }
        }

        [XmlIgnore]
        public bool DepartmentSpecified { get; set; }

        private List<string> _departmentFullPath = new List<string>();

        [XmlElement(ElementName = "departmentFullPath", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"66fe518a637c74cc4b2c97aa7f68fc49:110")]
        [MinLength(1)]
        public List<string> DepartmentFullPath
        {
            get => _departmentFullPath;
            set
            {
                DepartmentFullPathSpecified = true;
                _departmentFullPath = value;
            }
        }

        [XmlIgnore]
        public bool DepartmentFullPathSpecified { get; set; }

    }
}
