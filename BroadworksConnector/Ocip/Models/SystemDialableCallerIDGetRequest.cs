using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the system level Dialable Caller ID criteria list.
    /// The response is either a SystemDialableCallerIDGetResponse or an ErrorResponse.
    /// <see cref="SystemDialableCallerIDGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:7944""}]")]
    public class SystemDialableCallerIDGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
