using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get system Automatic Collect Call service settings.
    /// The response is either SystemAutomaticCollectCallGetResponse22 or ErrorResponse.
    /// <see cref="SystemAutomaticCollectCallGetResponse22"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]


    public class SystemAutomaticCollectCallGetRequest22 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
