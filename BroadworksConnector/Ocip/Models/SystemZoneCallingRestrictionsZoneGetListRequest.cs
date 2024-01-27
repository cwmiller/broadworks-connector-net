using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Gets a list of all zones defined in the system
    /// The response is SystemZoneCallingRestrictionsZoneGetListResponse or an ErrorResponse.
    /// Replaced by: SystemZoneGetListRequest
    /// <see cref="SystemZoneCallingRestrictionsZoneGetListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemZoneGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:39994""}]")]
    public class SystemZoneCallingRestrictionsZoneGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemZoneCallingRestrictionsZoneGetListResponse>
    {

    }
}
