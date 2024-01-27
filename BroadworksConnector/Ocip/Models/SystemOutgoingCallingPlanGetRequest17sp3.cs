using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system level data associated with Outgoing Calling Plan.
    /// The response is either a SystemOutgoingCallingPlanGetResponse17sp3 or an ErrorResponse.
    /// <see cref="SystemOutgoingCallingPlanGetResponse17sp3"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""a63afa661ee5c74f4700e562e88c66d0:971""}]")]
    public class SystemOutgoingCallingPlanGetRequest17sp3 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemOutgoingCallingPlanGetResponse17sp3>
    {

    }
}
