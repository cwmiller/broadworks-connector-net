using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests a table of all the existing Call Blocking Service Mappings in the system.
    /// 
    /// The response is either a SystemTreatmentMappingCallBlockingServiceGetListResponse23V3 or an ErrorResponse.
    /// <see cref="SystemTreatmentMappingCallBlockingServiceGetListResponse23V3"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:18730""}]")]
    public class SystemTreatmentMappingCallBlockingServiceGetListRequest23V3 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
