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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6f793dfca9bd3d121bb35e0f9cf1cb2e:972""}]")]
    public class SystemOutgoingCallingPlanGetRequest17sp3 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
