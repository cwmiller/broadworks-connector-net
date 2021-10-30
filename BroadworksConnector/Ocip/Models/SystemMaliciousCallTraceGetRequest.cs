using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get Malicious Call Trace system parameters and the list of users that use the
    /// Malicious Call Trace feature.
    /// The response is either a SystemMaliciousCallTraceGetResponse or
    /// an ErrorResponse.
    /// <see cref="SystemMaliciousCallTraceGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""0da7c658f240cdc10c3f9cb328db57d8:100""}]")]
    public class SystemMaliciousCallTraceGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemMaliciousCallTraceGetResponse>
    {

    }
}
