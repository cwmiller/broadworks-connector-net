using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests a table of all the existing Network SIP Status Code Mappings in the system.
    /// The response is either an SystemTreatmentMappingNetworkSIPStatusGetListResponse
    /// or an ErrorResponse.
    /// <see cref="SystemTreatmentMappingNetworkSIPStatusGetListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:19212""}]")]
    public class SystemTreatmentMappingNetworkSIPStatusGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemTreatmentMappingNetworkSIPStatusGetListResponse>
    {

    }
}
