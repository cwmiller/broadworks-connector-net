using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system's legacy automatic callback line type settings.
    /// The response is either a SystemLegacyAutomaticCallbackGetLineTypeListResponse or
    /// an ErrorResponse.
        /// <see cref="SystemLegacyAutomaticCallbackGetLineTypeListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemLegacyAutomaticCallbackGetLineTypeListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
