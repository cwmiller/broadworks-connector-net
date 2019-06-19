using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system level data associated with Call Me Now service.
    /// The response is either a SystemCallMeNowGetResponse or an ErrorResponse.
    /// <see cref="SystemCallMeNowGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""1f0f230fee2817fe00157925859dc28e:47""}]")]
    public class SystemCallMeNowGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
