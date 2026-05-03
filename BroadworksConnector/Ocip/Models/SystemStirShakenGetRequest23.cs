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
    /// Replaced by SystemStirShakenGetRequest23V2.
    /// <see cref="SystemStirShakenGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemStirShakenGetRequest23V2"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]


    public class SystemStirShakenGetRequest23 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemStirShakenGetResponse23>
    {

    }
}
