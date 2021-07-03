using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system level data associated with the Busy Lamp
    /// Field service. The response is either a SystemBusyLampFieldGetResponse18 or an ErrorResponse.
    /// 
    /// Replaced by: SystemBusyLampFieldGetRequest23 in AS data mode.
    /// <see cref="SystemBusyLampFieldGetResponse18"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemBusyLampFieldGetRequest23"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""de4d76f01f337fe4694212ec9f771753:6938""}]")]
    public class SystemBusyLampFieldGetRequest18 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
