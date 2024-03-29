using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system level data associated with the Busy Lamp
    /// Field service.
    /// 
    /// The response is either a SystemBusyLampFieldGetResponse23V2 or an ErrorResponse.
    /// <see cref="SystemBusyLampFieldGetResponse23V2"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""b1745b5f688013b73224574a66f4f4b2:47""}]")]
    public class SystemBusyLampFieldGetRequest23V2 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemBusyLampFieldGetResponse23V2>
    {

    }
}
