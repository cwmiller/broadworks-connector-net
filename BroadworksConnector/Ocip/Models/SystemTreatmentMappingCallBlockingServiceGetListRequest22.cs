using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests a table of all the existing Call Blocking Service Mappings in the system.
    /// The response is either a SystemTreatmentMappingCallBlockingServiceGetListResponse22
    /// or an ErrorResponse.
    /// Replaced by: SystemTreatmentMappingCallBlockingServiceGetListRequest23
    /// <see cref="SystemTreatmentMappingCallBlockingServiceGetListResponse22"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemTreatmentMappingCallBlockingServiceGetListRequest23"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""de4d76f01f337fe4694212ec9f771753:6655""}]")]
    public class SystemTreatmentMappingCallBlockingServiceGetListRequest22 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
