using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the list of Network Device Polling system parameters.
    /// The response is either SystemNetworkDeviceMonitorParametersGetResponse or ErrorResponse.
    /// <see cref="SystemNetworkDeviceMonitorParametersGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:12601""}]")]
    public class SystemNetworkDeviceMonitorParametersGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
