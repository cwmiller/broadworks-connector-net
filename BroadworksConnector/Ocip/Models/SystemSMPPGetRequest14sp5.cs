using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system level data associated with SMPP external interface.
    /// The response is either a SystemSMPPGetResponse14sp5 or an ErrorResponse.
    /// 
    /// Replaced by: SystemSMPPGetRequest21 in AS data mode
    /// <see cref="SystemSMPPGetResponse14sp5"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemSMPPGetRequest21"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""240b50f54d060859e5e275082fdf49f9:15284""}]")]
    public class SystemSMPPGetRequest14sp5 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemSMPPGetResponse14sp5>
    {

    }
}
