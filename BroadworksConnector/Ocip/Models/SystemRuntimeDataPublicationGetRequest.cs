using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the system call admission control parameters.
    /// The response is either a SystemRuntimeDataPublicationGetResponse or an ErrorResponse.
    /// <see cref="SystemRuntimeDataPublicationGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:15573""}]")]
    public class SystemRuntimeDataPublicationGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
