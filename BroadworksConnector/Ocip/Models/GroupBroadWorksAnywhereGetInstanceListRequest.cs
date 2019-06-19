using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get a list of BroadWorks Anywhere instances within a group.
    /// The response is either GroupBroadWorksAnywhereGetInstanceListResponse or ErrorResponse.
    /// It is possible to get the instances within a specified department.
    /// <see cref="GroupBroadWorksAnywhereGetInstanceListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""72f634ecc58842ce9d362ca629a47ea9:105""}]")]
    public class GroupBroadWorksAnywhereGetInstanceListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"72f634ecc58842ce9d362ca629a47ea9:105")]
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
        [Group(@"72f634ecc58842ce9d362ca629a47ea9:105")]
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

        private string _groupDepartmentName;

        [XmlElement(ElementName = "groupDepartmentName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"72f634ecc58842ce9d362ca629a47ea9:105")]
        [MinLength(1)]
        [MaxLength(50)]
        public string GroupDepartmentName
        {
            get => _groupDepartmentName;
            set
            {
                GroupDepartmentNameSpecified = true;
                _groupDepartmentName = value;
            }
        }

        [XmlIgnore]
        public bool GroupDepartmentNameSpecified { get; set; }

    }
}
