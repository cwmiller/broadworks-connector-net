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
    /// <see cref="SystemStirShakenGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]


    public class SystemStirShakenGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
