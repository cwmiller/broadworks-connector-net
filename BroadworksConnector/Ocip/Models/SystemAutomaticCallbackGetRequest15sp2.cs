using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system's automatic callback attributes.
    /// The response is either a SystemAutomaticCallbackGetResponse15sp2 or an ErrorResponse.
    /// Replaced by: SystemAutomaticCallbackGetRequest17
        /// <see cref="SystemAutomaticCallbackGetResponse15sp2"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="SystemAutomaticCallbackGetRequest17"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemAutomaticCallbackGetRequest15sp2 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
