using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system's automatic callback attributes.
    /// The response is either a SystemAutomaticCallbackGetResponse or an ErrorResponse.
    /// Replaced By: SystemAutomaticCallbackGetRequest15
        /// <see cref="SystemAutomaticCallbackGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="SystemAutomaticCallbackGetRequest15"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemAutomaticCallbackGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
