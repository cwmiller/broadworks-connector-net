using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Gets system level the Location Based Calling Restrictions attributes.
    /// The response is either a SystemLocationBasedCallingRestrictionsGetResponse17sp3 or an ErrorResponse.
    /// <see cref="SystemLocationBasedCallingRestrictionsGetResponse17sp3"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7770900887d4397dd29272c7b9c55bc4:43""}]")]
    public class SystemLocationBasedCallingRestrictionsGetRequest17sp3 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemLocationBasedCallingRestrictionsGetResponse17sp3>
    {

    }
}
