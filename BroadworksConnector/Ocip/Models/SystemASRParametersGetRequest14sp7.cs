using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the list of Application Server Registration system parameters.
    /// The response is either SystemASRParametersGetResponse14sp7 or ErrorResponse.
    /// <see cref="SystemASRParametersGetResponse14sp7"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:1930""}]")]
    public class SystemASRParametersGetRequest14sp7 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
