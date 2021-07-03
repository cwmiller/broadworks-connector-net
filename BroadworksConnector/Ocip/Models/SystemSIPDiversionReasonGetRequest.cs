using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the list of SIP Diversion Cause values.
    /// The response is either a SystemSIPDiversionReasonGetResponse or ErrorResponse.
    /// <see cref="SystemSIPDiversionReasonGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:17478""}]")]
    public class SystemSIPDiversionReasonGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
