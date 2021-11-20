using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests the list of time zone names.
    /// The response is either SystemTimeZoneGetListResponse or ErrorResponse.
    /// 
    /// Replaced by: SystemTimeZoneGetListRequest20 in AS data mode
    /// <see cref="SystemTimeZoneGetListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemTimeZoneGetListRequest20"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""de4d76f01f337fe4694212ec9f771753:11607""}]")]
    public class SystemTimeZoneGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemTimeZoneGetListResponse>
    {

    }
}
