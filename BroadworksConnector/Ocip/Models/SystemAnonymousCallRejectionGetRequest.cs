using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get Anonymous Call Rejection system parameters.
    /// The response is either a SystemAnonymousCallRejectionGetResponse or
    /// an ErrorResponse.
    /// <see cref="SystemAnonymousCallRejectionGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""17d2110a0df023b843fdbd156e17bec8:46""}]")]
    public class SystemAnonymousCallRejectionGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemAnonymousCallRejectionGetResponse>
    {

    }
}
