using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the speed dial 100 system-wide default setting.
    /// The response is either a SystemSpeedDial100GetResponse17sp1 or an ErrorResponse.
    /// <see cref="SystemSpeedDial100GetResponse17sp1"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""066a3d16bce438447d23cbe6ff0885a6:98""}]")]
    public class SystemSpeedDial100GetRequest17sp1 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
