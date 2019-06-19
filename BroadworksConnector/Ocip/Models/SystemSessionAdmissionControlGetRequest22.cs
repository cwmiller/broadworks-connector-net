using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the session admission control settings for the system.
    /// The response is either a SystemSessionAdmissionControlGetResponse22 or an ErrorResponse.
    /// <see cref="SystemSessionAdmissionControlGetResponse22"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:15097""}]")]
    public class SystemSessionAdmissionControlGetRequest22 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
