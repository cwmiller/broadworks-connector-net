using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system level data associated with Hunt Group.
    /// The response is either a SystemHuntGroupGetResponse17 or an
    /// ErrorResponse.
    /// Replaced by: SystemHuntGroupGetRequest21 in AS data mode
    /// <see cref="SystemHuntGroupGetResponse17"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemHuntGroupGetRequest21"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""240b50f54d060859e5e275082fdf49f9:10404""}]")]
    public class SystemHuntGroupGetRequest17 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemHuntGroupGetResponse17>
    {

    }
}
