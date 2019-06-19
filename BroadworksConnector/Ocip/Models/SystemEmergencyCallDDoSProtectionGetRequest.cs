using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the system Emergency Call DDos Protection configurations.
    /// The response is either SystemEmergencyCallDDoSProtectionGetResponse or ErrorResponse.
    /// <see cref="SystemEmergencyCallDDoSProtectionGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:8615""}]")]
    public class SystemEmergencyCallDDoSProtectionGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
