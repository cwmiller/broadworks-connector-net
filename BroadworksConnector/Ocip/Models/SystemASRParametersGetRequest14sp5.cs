using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the list of Application Server Registration system parameters.
    /// The response is either SystemASRParametersGetResponse14sp5 or ErrorResponse.
    /// <see cref="SystemASRParametersGetResponse14sp5"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:4194""}]")]
    public class SystemASRParametersGetRequest14sp5 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
