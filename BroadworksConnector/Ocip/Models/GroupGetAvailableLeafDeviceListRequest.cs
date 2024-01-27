using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests the list of available leaf devices that can be linked to a tree device within a specific group.
    /// A leaf device is a device associated with a device type that has the option
    /// supportLinks set to "Support Link to Device". It can be linked to only one tree device.
    /// The list returned includes devices created at the system, service provider, and group levels.
    /// The response is either GroupGetAvailableLeafDeviceListResponse or
    /// ErrorResponse.
    /// 
    /// Replaced by: GroupGetAvailableLeafDeviceListRequest22.
    /// <see cref="GroupGetAvailableLeafDeviceListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="GroupGetAvailableLeafDeviceListRequest22"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:10090""}]")]
    public class GroupGetAvailableLeafDeviceListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.GroupGetAvailableLeafDeviceListResponse>
    {

        protected string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:10090")]
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
        [Group(@"d8f04177e438f303b41c211e518706bf:10090")]
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

    }
}
