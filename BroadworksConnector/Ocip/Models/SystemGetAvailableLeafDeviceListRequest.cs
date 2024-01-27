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
    /// supportLinks set to "Support Link to Device". It can be linked to only one tree device.
    /// The list returned includes devices created at the system, service provider, and group levels.
    /// The response is either SystemGetAvailableLeafDeviceListResponse or
    /// ErrorResponse.
    /// Replaced by: SystemGetAvailableLeafDeviceListRequest22.
    /// <see cref="SystemGetAvailableLeafDeviceListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemGetAvailableLeafDeviceListRequest22"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:27447""}]")]
    public class SystemGetAvailableLeafDeviceListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemGetAvailableLeafDeviceListResponse>
    {

    }
}
