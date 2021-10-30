using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system level data associated with Call Waiting.
    /// The response is either a SystemCallWaitingGetResponse or an
    /// ErrorResponse.
    /// <see cref="SystemCallWaitingGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e12337fe0480db757507a0699bc195d9:44""}]")]
    public class SystemCallWaitingGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemCallWaitingGetResponse>
    {

    }
}
