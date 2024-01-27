using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get system Stir Shaken service settings.
    /// The response is either SystemStirShakenGetResponse or ErrorResponse.
    /// Replaced by SystemStirShakenGetRequest23.
    /// <see cref="SystemStirShakenGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemStirShakenGetRequest23"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]


    public class SystemStirShakenGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemStirShakenGetResponse>
    {

    }
}
