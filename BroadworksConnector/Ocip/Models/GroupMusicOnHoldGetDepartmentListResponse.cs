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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""3a0309eb8d406fefc891f554ef114669:113""}]")]
    public class GroupMusicOnHoldGetDepartmentListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _hasDepartment;

        [XmlElement(ElementName = "hasDepartment", IsNullable = false, Namespace = "")]
        [Group(@"3a0309eb8d406fefc891f554ef114669:113")]
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
        protected bool HasDepartmentSpecified { get; set; }

        protected List<BroadWorksConnector.Ocip.Models.DepartmentKey> _department = new List<BroadWorksConnector.Ocip.Models.DepartmentKey>();

        [XmlElement(ElementName = "department", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3a0309eb8d406fefc891f554ef114669:113")]
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
        protected bool DepartmentSpecified { get; set; }

        protected List<string> _departmentFullPath = new List<string>();

        [XmlElement(ElementName = "departmentFullPath", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3a0309eb8d406fefc891f554ef114669:113")]
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
        protected bool DepartmentFullPathSpecified { get; set; }

    }
}
