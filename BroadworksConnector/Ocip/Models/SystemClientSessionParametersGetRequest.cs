using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the list of Client Session (web and CLI) system parameters.
    /// The response is either SystemClientSessionParametersGetResponse or ErrorResponse.
    /// <see cref="SystemClientSessionParametersGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:5087""}]")]
    public class SystemClientSessionParametersGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
