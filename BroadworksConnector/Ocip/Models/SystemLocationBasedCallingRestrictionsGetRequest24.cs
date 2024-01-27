using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Gets system level the Location Based Calling Restrictions attributes.
    /// The response is either a SystemLocationBasedCallingRestrictionsGetResponse24 or an ErrorResponse.
    /// <see cref="SystemLocationBasedCallingRestrictionsGetResponse24"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4489f4baeefa41b8df0a86def4c05cd8:46""}]")]
    public class SystemLocationBasedCallingRestrictionsGetRequest24 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemLocationBasedCallingRestrictionsGetResponse24>
    {

    }
}
