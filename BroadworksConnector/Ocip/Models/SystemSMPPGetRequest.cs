using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system level data associated with SMPP external interface.
    /// The response is either a SystemSMPPGetResponse or an ErrorResponse.
    /// Replaced By: SystemSMPPGetRequest14sp5
    /// <see cref="SystemSMPPGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemSMPPGetRequest14sp5"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:35509""}]")]
    public class SystemSMPPGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemSMPPGetResponse>
    {

    }
}
