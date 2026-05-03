using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get system Stir Shaken service settings.
    /// The response is either SystemStirShakenGetResponse23V3 or ErrorResponse.
    /// Replaced by SystemStirShakenGetRequest23V4.
    /// <see cref="SystemStirShakenGetResponse23V3"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemStirShakenGetRequest23V4"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]


    public class SystemStirShakenGetRequest23V3 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemStirShakenGetResponse23V3>
    {

    }
}
