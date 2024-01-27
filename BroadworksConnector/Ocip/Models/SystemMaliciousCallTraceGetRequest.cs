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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""be7f3162f133f8d7fcc75e712b0258e6:100""}]")]
    public class SystemMaliciousCallTraceGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemMaliciousCallTraceGetResponse>
    {

    }
}
