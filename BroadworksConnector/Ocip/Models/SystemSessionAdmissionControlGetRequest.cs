using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the session admission control settings for the system.
    /// The response is either a SystemSessionAdmissionControlGetResponse or an ErrorResponse.
    /// 
    /// Replaced by: SystemSessionAdmissionControlGetRequest21sp1.
    /// <see cref="SystemSessionAdmissionControlGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemSessionAdmissionControlGetRequest21sp1"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:29659""}]")]
    public class SystemSessionAdmissionControlGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemSessionAdmissionControlGetResponse>
    {

    }
}
