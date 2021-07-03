using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the system number formatting parameters.
    /// The response is either SystemNumberFormattingParametersGetResponse or ErrorResponse.
    /// <see cref="SystemNumberFormattingParametersGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:12995""}]")]
    public class SystemNumberFormattingParametersGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
