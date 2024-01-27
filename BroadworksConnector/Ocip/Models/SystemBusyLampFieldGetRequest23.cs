using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system level data associated with the Busy Lamp
    /// Field service. The response is either a SystemBusyLampFieldGetResponse23 or an ErrorResponse.
    /// Replaced by: SystemBusyLampFieldGetRequest23V2 in AS data mode.
    /// <see cref="SystemBusyLampFieldGetResponse23"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemBusyLampFieldGetRequest23V2"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""240b50f54d060859e5e275082fdf49f9:8358""}]")]
    public class SystemBusyLampFieldGetRequest23 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemBusyLampFieldGetResponse23>
    {

    }
}
