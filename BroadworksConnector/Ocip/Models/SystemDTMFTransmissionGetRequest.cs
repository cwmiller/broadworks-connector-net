using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the system DTMF transmission configurations.
    /// The response is either SystemDTMFTransmissionGetResponse or ErrorResponse.
    /// <see cref="SystemDTMFTransmissionGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:9597""}]")]
    public class SystemDTMFTransmissionGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
