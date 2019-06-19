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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:17578""}]")]
    public class SystemTreatmentMappingAccessSIPStatusGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
