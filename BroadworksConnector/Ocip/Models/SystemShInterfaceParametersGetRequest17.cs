using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Retrieves the Sh Interface system parameters.
    /// The response is either a SystemShInterfaceParametersGetResponse or an ErrorResponse.
    /// <see cref="SystemShInterfaceParametersGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:16392""}]")]
    public class SystemShInterfaceParametersGetRequest17 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
