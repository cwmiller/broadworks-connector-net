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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4277c572e54919d6e29f4c0fa69aaad1:45""}]")]
    public class SystemCommunicationBarringUserControlGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
