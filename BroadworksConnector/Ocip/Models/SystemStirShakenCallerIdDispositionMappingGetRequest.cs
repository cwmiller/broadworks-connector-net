using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the Caller Id Disposition mapping.
    /// 
    /// The response is either SystemStirShakenCallerIdDispositionMappingGetResponse or ErrorResponse.
    /// <see cref="SystemStirShakenCallerIdDispositionMappingGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]


    public class SystemStirShakenCallerIdDispositionMappingGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemStirShakenCallerIdDispositionMappingGetResponse>
    {

    }
}
