using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get a list of monitored device types.
    /// The response is either a SystemAccessDeviceMonitorGetDeviceTypeListResponse or an ErrorResponse.
    /// <see cref="SystemAccessDeviceMonitorGetDeviceTypeListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:1636""}]")]
    public class SystemAccessDeviceMonitorGetDeviceTypeListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemAccessDeviceMonitorGetDeviceTypeListResponse>
    {

    }
}
