using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system's legacy automatic callback attributes.
    /// The response is either a SystemLegacyAutomaticCallbackGetResponse or an ErrorResponse.
        /// <see cref="SystemLegacyAutomaticCallbackGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemLegacyAutomaticCallbackGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
