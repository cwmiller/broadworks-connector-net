using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get a list of Trunk Groups for the group or enterprise.
    /// It is possible to restrict the results to a particular department, or expand the list to the entire enterprise.
    /// The response is either a GroupTrunkGroupGetInstanceListResponse14sp4 or an ErrorResponse.
    /// <see cref="GroupTrunkGroupGetInstanceListResponse14sp4"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""090e91b2d78e873f5d76a2f16af08d3a:1110"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""090e91b2d78e873f5d76a2f16af08d3a:1113"",""optional"":true}]}]")]
    public class GroupTrunkGroupGetInstanceListRequest14sp4 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.GroupTrunkGroupGetInstanceListResponse14sp4>
    {

        protected string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"090e91b2d78e873f5d76a2f16af08d3a:1110")]
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
        protected bool ServiceProviderIdSpecified { get; set; }

        protected string _groupId;

        [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
        [Group(@"090e91b2d78e873f5d76a2f16af08d3a:1110")]
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
        protected bool GroupIdSpecified { get; set; }

        protected string _groupDepartmentName;

        [XmlElement(ElementName = "groupDepartmentName", IsNullable = false, Namespace = "")]
        [Group(@"090e91b2d78e873f5d76a2f16af08d3a:1113")]
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
        protected bool GroupDepartmentNameSpecified { get; set; }

        protected bool _includeEnterpriseTrunkGroups;

        [XmlElement(ElementName = "includeEnterpriseTrunkGroups", IsNullable = false, Namespace = "")]
        [Group(@"090e91b2d78e873f5d76a2f16af08d3a:1113")]
        public bool IncludeEnterpriseTrunkGroups
        {
            get => _includeEnterpriseTrunkGroups;
            set
            {
                IncludeEnterpriseTrunkGroupsSpecified = true;
                _includeEnterpriseTrunkGroups = value;
            }
        }

        [XmlIgnore]
        protected bool IncludeEnterpriseTrunkGroupsSpecified { get; set; }

        protected bool _onlyTrunkGroupsWithDevice;

        [XmlElement(ElementName = "onlyTrunkGroupsWithDevice", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"090e91b2d78e873f5d76a2f16af08d3a:1110")]
        public bool OnlyTrunkGroupsWithDevice
        {
            get => _onlyTrunkGroupsWithDevice;
            set
            {
                OnlyTrunkGroupsWithDeviceSpecified = true;
                _onlyTrunkGroupsWithDevice = value;
            }
        }

        [XmlIgnore]
        protected bool OnlyTrunkGroupsWithDeviceSpecified { get; set; }

    }
}
