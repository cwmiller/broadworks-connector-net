using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get system Security Classifications parameters.
    /// The response is either SystemSecurityClassificationGetResponse21 or ErrorResponse.
    /// <see cref="SystemSecurityClassificationGetResponse21"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]


    public class SystemSecurityClassificationGetRequest21 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
