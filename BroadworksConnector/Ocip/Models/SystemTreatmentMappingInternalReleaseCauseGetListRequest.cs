using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests a table of all the Internal Release Cause mappings in the system.
    /// The response is either a SystemTreatmentMappingInternalReleaseCauseGetListResponse
    /// or an ErrorResponse.
    /// <see cref="SystemTreatmentMappingInternalReleaseCauseGetListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:19050""}]")]
    public class SystemTreatmentMappingInternalReleaseCauseGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemTreatmentMappingInternalReleaseCauseGetListResponse>
    {

    }
}
