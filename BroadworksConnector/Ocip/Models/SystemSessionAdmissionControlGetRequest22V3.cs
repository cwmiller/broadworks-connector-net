using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the session admission control settings for the system.
    /// The response is either a SystemSessionAdmissionControlGetResponse22V3 or an ErrorResponse.
    /// <see cref="SystemSessionAdmissionControlGetResponse22V3"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:29720""}]")]
    public class SystemSessionAdmissionControlGetRequest22V3 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemSessionAdmissionControlGetResponse22V3>
    {

    }
}
