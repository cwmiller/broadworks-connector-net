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
    /// supportLinks set to "Support Link to Device" or "Support Link to Device and User".  It can
    /// be linked to only one tree device.
    /// The list returned includes devices created at the system, service provider, and group levels.
    /// If the leafDeviceCategory is not set in the request, then linked leaf devices of all categories are requested, otherwise only the linked leaf devices of the specified category are requested.
    /// The category values are: "Handset", "Base Station", "All".
    /// 
    /// The response is either GroupGetAvailableLeafDeviceListResponse22 or
    /// ErrorResponse.
    /// <see cref="GroupGetAvailableLeafDeviceListResponse22"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4b0e7857796c636464362260a2f8e5ee:5716""}]")]
    public class GroupGetAvailableLeafDeviceListRequest22 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.GroupGetAvailableLeafDeviceListResponse22>
    {

        protected string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:5716")]
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
        [Group(@"4b0e7857796c636464362260a2f8e5ee:5716")]
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

        protected BroadWorksConnector.Ocip.Models.LeafDeviceCategory _leafDeviceCategory;

        [XmlElement(ElementName = "leafDeviceCategory", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:5716")]
        public BroadWorksConnector.Ocip.Models.LeafDeviceCategory LeafDeviceCategory
        {
            get => _leafDeviceCategory;
            set
            {
                LeafDeviceCategorySpecified = true;
                _leafDeviceCategory = value;
            }
        }

        [XmlIgnore]
        protected bool LeafDeviceCategorySpecified { get; set; }

    }
}
