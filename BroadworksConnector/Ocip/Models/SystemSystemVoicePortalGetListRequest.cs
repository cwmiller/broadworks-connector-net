using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the list of the system voice portals.
    /// The response is either SystemSystemVoicePortalGetListResponse or ErrorResponse.
    /// <see cref="SystemSystemVoicePortalGetListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]


    public class SystemSystemVoicePortalGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemSystemVoicePortalGetListResponse>
    {

    }
}
