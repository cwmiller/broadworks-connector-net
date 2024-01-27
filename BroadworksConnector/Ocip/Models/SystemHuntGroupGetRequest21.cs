using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system level data associated with Hunt Group.
    /// The response is either a SystemHuntGroupGetResponse21 or an
    /// ErrorResponse.
    /// <see cref="SystemHuntGroupGetResponse21"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""781bbab86d937537938d4fe917029d5c:584""}]")]
    public class SystemHuntGroupGetRequest21 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemHuntGroupGetResponse21>
    {

    }
}
