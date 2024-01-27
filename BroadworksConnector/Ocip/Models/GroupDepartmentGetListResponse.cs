using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupDepartmentGetListRequest.
    /// The response includes two parallel arrays of department keys and department display names.
    /// 
    /// Replaced by: GroupDepartmentGetListResponse18
    /// <see cref="GroupDepartmentGetListRequest"/>
    /// <see cref="GroupDepartmentGetListResponse18"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:9198""}]")]
    public class GroupDepartmentGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected List<BroadWorksConnector.Ocip.Models.DepartmentKey> _departmentKey = new List<BroadWorksConnector.Ocip.Models.DepartmentKey>();

        [XmlElement(ElementName = "departmentKey", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:9198")]
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

        protected List<string> _fullPathName = new List<string>();

        [XmlElement(ElementName = "fullPathName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:9198")]
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
