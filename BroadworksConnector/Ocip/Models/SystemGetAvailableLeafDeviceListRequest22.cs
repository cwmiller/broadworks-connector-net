using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests the list of available leaf devices that can be linked to a tree device for the entire system.
    /// A leaf device is a device associated with a device type that has the option
    /// supportLinks set to "Support Link to Device" or "Support Link to Device and User".  It can
    /// be linked to only one tree device.
    /// The list returned includes devices created at the system, service provider, and group levels.
    /// If the leafDeviceCategory is not set in the request, then linked leaf devices of all categories are requested, otherwise only the linked leaf devices of the specified category are requested.
    /// The category values are: "Handset", "Base Station", "All".
    /// The response is either SystemGetAvailableLeafDeviceListResponse22 or
    /// ErrorResponse.
    /// <see cref="SystemGetAvailableLeafDeviceListResponse22"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:10761""}]")]
    public class SystemGetAvailableLeafDeviceListRequest22 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemGetAvailableLeafDeviceListResponse22>
    {

        protected BroadWorksConnector.Ocip.Models.LeafDeviceCategory _leafDeviceCategory;

        [XmlElement(ElementName = "leafDeviceCategory", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:10761")]
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
