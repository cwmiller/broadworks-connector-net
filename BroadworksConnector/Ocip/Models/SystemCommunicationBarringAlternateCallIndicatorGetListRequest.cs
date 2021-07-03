using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get all the Communication Barring Alternate Call Indicator defined
    /// in the system. The response is either a SystemCommunicationBarringAlternateCallIndicatorGetListResponse or an ErrorResponse.
    /// <see cref="SystemCommunicationBarringAlternateCallIndicatorGetListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:5569""}]")]
    public class SystemCommunicationBarringAlternateCallIndicatorGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
