using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system level data associated with collaborate services.
    /// The response is either a SystemCollaborateGetResponse20sp1V2 or an ErrorResponse.
    /// <see cref="SystemCollaborateGetResponse20sp1V2"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""939fd5846dfae8bdf58308d6cb9ebb12:512""}]")]
    public class SystemCollaborateGetRequest20sp1V2 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemCollaborateGetResponse20sp1V2>
    {

    }
}
