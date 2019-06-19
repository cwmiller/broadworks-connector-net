using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the list of Redundancy system parameters.
    /// The response is either SystemRedundancyParametersGetResponse16sp2 or ErrorResponse.
    /// <see cref="SystemRedundancyParametersGetResponse16sp2"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:13797""}]")]
    public class SystemRedundancyParametersGetRequest16sp2 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
