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
    /// 
    /// Replaced by: SystemLocationBasedCallingRestrictionsGetRequest24
    /// <see cref="SystemLocationBasedCallingRestrictionsGetResponse17sp3"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemLocationBasedCallingRestrictionsGetRequest24"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:28001""}]")]
    public class SystemLocationBasedCallingRestrictionsGetRequest17sp3 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemLocationBasedCallingRestrictionsGetResponse17sp3>
    {

    }
}
