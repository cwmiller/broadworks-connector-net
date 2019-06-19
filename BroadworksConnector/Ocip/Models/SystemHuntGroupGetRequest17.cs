using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system level data associated with Hunt Group.
    /// The response is either a SystemHuntGroupGetResponse or an ErrorResponse.
    /// Replaced by: SystemHuntGroupGetRequest21 in AS data mode
    /// <see cref="SystemHuntGroupGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemHuntGroupGetRequest21"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""de4d76f01f337fe4694212ec9f771753:3044""}]")]
    public class SystemHuntGroupGetRequest17 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
