using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system's automatic callback attributes.
    /// The response is either a SystemAutomaticCallbackGetResponse15 or an ErrorResponse.
    /// Replaced By: SystemAutomaticCallbackGetRequest15sp2
        /// <see cref="SystemAutomaticCallbackGetResponse15"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="SystemAutomaticCallbackGetRequest15sp2"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemAutomaticCallbackGetRequest15 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
