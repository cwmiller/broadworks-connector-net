using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to EnterpriseDepartmentGetListRequest.
    /// The response includes two parallel arrays of department keys and department display names.
    /// <see cref="EnterpriseDepartmentGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""5395c7df0157d44aa22f3351d1a5f3da:723""}]")]
    public class EnterpriseDepartmentGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private List<BroadWorksConnector.Ocip.Models.DepartmentKey> _departmentKey = new List<BroadWorksConnector.Ocip.Models.DepartmentKey>();

        [XmlElement(ElementName = "departmentKey", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"5395c7df0157d44aa22f3351d1a5f3da:723")]
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
        public bool DepartmentKeySpecified { get; set; }

        private List<string> _fullPathName = new List<string>();

        [XmlElement(ElementName = "fullPathName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"5395c7df0157d44aa22f3351d1a5f3da:723")]
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
        public bool FullPathNameSpecified { get; set; }

    }
}
