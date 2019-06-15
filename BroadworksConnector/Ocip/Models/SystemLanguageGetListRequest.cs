using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the defined languages in the system.
    /// The response is either a SystemLanguageGetListResponse or an ErrorResponse.
        /// <see cref="SystemLanguageGetListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemLanguageGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
