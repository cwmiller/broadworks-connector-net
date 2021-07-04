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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:18815""}]")]
    public class SystemTreatmentMappingInternalReleaseCauseGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
