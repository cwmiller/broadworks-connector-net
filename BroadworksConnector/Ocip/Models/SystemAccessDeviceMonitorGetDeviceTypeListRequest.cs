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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:1173""}]")]
    public class SystemAccessDeviceMonitorGetDeviceTypeListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
