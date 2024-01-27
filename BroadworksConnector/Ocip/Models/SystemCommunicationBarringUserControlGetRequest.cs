using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Gets the Communication Barring system level settings.
    /// The response is either SystemCommunicationBarringUserControlGetResponse or ErrorResponse.
    /// <see cref="SystemCommunicationBarringUserControlGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6844af6fc359ada5d958622d62cbd13f:45""}]")]
    public class SystemCommunicationBarringUserControlGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemCommunicationBarringUserControlGetResponse>
    {

    }
}
