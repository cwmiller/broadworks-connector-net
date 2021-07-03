using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system level data associated with Communication Barring.
    /// The response is either a SystemCommunicationBarringGetResponse21sp1 or an ErrorResponse.
    /// <see cref="SystemCommunicationBarringGetResponse21sp1"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:6072""}]")]
    public class SystemCommunicationBarringGetRequest21sp1 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
