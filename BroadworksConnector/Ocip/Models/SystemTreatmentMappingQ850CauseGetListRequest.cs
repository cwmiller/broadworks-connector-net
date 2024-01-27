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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:19293""}]")]
    public class SystemTreatmentMappingQ850CauseGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemTreatmentMappingQ850CauseGetListResponse>
    {

    }
}
