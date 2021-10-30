using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get system Automatic Collect Call service settings.
    /// The response is either SystemAutomaticCollectCallGetResponse or ErrorResponse.
    /// 
    /// Replaced by SystemAutomaticCollectCallGetRequest in AS mode.
    /// <see cref="SystemAutomaticCollectCallGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemAutomaticCollectCallGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]


    public class SystemAutomaticCollectCallGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemAutomaticCollectCallGetResponse>
    {

    }
}
