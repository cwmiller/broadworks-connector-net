using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the expensive call notification service parameters.
    /// The response is either a SystemExpensiveCallNotificationGetResponse or an ErrorResponse.
    /// <see cref="SystemExpensiveCallNotificationGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:8769""}]")]
    public class SystemExpensiveCallNotificationGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
