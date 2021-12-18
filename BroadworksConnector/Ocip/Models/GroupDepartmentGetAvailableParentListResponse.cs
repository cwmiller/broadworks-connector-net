using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupDepartmentGetAvailableParentListRequest.
    /// The response includes two parallel arrays of department keys and department display names.
    /// <see cref="GroupDepartmentGetAvailableParentListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f3a93cf15de4abd7903673e44ee3e07b:3924""}]")]
    public class GroupDepartmentGetAvailableParentListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private List<BroadWorksConnector.Ocip.Models.DepartmentKey> _departmentKey = new List<BroadWorksConnector.Ocip.Models.DepartmentKey>();

        [XmlElement(ElementName = "departmentKey", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:3924")]
        public List<BroadWorksConnector.Ocip.Models.DepartmentKey> DepartmentKey
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

        private List<string> _fullPathName = new List<string>();

        [XmlElement(ElementName = "fullPathName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:3924")]
        [MinLength(1)]
        public List<string> FullPathName
        {
            get => _fullPathName;
            set
            {
                FullPathNameSpecified = true;
                _fullPathName = value;
            }
        }

        [XmlIgnore]
        protected bool FullPathNameSpecified { get; set; }

    }
}
