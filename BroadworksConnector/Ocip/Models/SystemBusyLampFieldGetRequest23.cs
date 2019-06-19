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
    /// <see cref="SystemBusyLampFieldGetResponse23"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4faeca417998d23ce2ff6b0b43212aa6:78""}]")]
    public class SystemBusyLampFieldGetRequest23 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
