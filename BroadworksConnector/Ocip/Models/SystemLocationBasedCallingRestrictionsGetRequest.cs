using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Gets system level the Location Based Calling Restrictions attributes.
    /// The response is either a SystemLocationBasedCallingRestrictionsGetResponse or an ErrorResponse.
    /// 
    /// Replaced by: SystemLocationBasedCallingRestrictionsGetRequest17sp3
    /// <see cref="SystemLocationBasedCallingRestrictionsGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemLocationBasedCallingRestrictionsGetRequest17sp3"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:27503""}]")]
    public class SystemLocationBasedCallingRestrictionsGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemLocationBasedCallingRestrictionsGetResponse>
    {

    }
}
