using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests the list of available tree devices to link to for the entire system.
    /// Requests the list of available tree devices to which a leaf device can be linked for the entire system.
    /// A tree device is a device associated with a device type that has the option
    /// supportLinks set to "Support Links from Devices". Many leaf devices can be linked to it.
    /// The list returned includes devices created at the system, service provider, and group levels.
    /// The response is either SystemGetAvailableTreeDeviceListResponse or
    /// ErrorResponse.
    /// <see cref="SystemGetAvailableTreeDeviceListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:10798""}]")]
    public class SystemGetAvailableTreeDeviceListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemGetAvailableTreeDeviceListResponse>
    {

    }
}
