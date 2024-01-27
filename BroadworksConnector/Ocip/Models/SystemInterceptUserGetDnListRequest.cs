using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get a list of Intercept User dns defined in the system.
    /// The response is either a SystemInterceptUserGetDnListResponse
    /// or an ErrorResponse.
    /// <see cref="SystemInterceptUserGetDnListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""2a762bb9361e88044885b796c1d6b979:176""}]")]
    public class SystemInterceptUserGetDnListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemInterceptUserGetDnListResponse>
    {

    }
}
