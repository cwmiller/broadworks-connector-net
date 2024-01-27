using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests a table of all the existing Access Side SIP Status Code Mappings in the system.
    /// The response is either an SystemTreatmentMappingAccessSIPStatusGetListResponse
    /// or an ErrorResponse.
    /// <see cref="SystemTreatmentMappingAccessSIPStatusGetListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:18883""}]")]
    public class SystemTreatmentMappingAccessSIPStatusGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemTreatmentMappingAccessSIPStatusGetListResponse>
    {

    }
}
