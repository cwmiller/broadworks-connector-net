using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the session admission control settings for the system.
    /// The response is either a SystemSessionAdmissionControlGetResponse22V2 or an ErrorResponse.
    /// 
    /// Replaced by: SystemSessionAdmissionControlGetRequest22V3
    /// <see cref="SystemSessionAdmissionControlGetResponse22V2"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemSessionAdmissionControlGetRequest22V3"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:29706""}]")]
    public class SystemSessionAdmissionControlGetRequest22V2 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemSessionAdmissionControlGetResponse22V2>
    {

    }
}
