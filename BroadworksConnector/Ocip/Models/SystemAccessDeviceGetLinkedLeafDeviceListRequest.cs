using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests the list of linked leaf devices for the system level tree device passed in the request.
    /// A tree device is a device associated with a device type that has the option
    /// supportLinks set to "Support Links from Devices". Many leaf devices can be linked to it.
    /// A leaf device is a device associated with a device type that has the option
    /// supportLinks set to "Support Link to Device". It can be linked to only one tree device.
    /// The list includes devices created at the system, service provider, and group levels.
    /// The response is either SystemAccessDeviceGetLinkedLeafDeviceListResponse or
    /// ErrorResponse.
    /// 
    /// Replaced by: SystemAccessDeviceGetLinkedLeafDeviceListRequest22.
    /// <see cref="SystemAccessDeviceGetLinkedLeafDeviceListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemAccessDeviceGetLinkedLeafDeviceListRequest22"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:20200""}]")]
    public class SystemAccessDeviceGetLinkedLeafDeviceListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemAccessDeviceGetLinkedLeafDeviceListResponse>
    {

        protected string _deviceName;

        [XmlElement(ElementName = "deviceName", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:20200")]
        [MinLength(1)]
        [MaxLength(40)]
        public string DeviceName
        {
            get => _deviceName;
            set
            {
                DeviceNameSpecified = true;
                _deviceName = value;
            }
        }

        [XmlIgnore]
        protected bool DeviceNameSpecified { get; set; }

    }
}
