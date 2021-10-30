using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests a table of all the existing Q850 Cause Value Mappings in the system.
    /// The response is either a SystemTreatmentMappingQ850CauseGetListResponse
    /// or an ErrorResponse.
    /// <see cref="SystemTreatmentMappingQ850CauseGetListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:19057""}]")]
    public class SystemTreatmentMappingQ850CauseGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemTreatmentMappingQ850CauseGetListResponse>
    {

    }
}
