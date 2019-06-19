using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system level data associated with Fax Messaging.
    /// The response is either a SystemFaxMessagingGetResponse or an ErrorResponse.
    /// <see cref="SystemFaxMessagingGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f46f967f937c7dc89ddb3db423383aa4:43""}]")]
    public class SystemFaxMessagingGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
