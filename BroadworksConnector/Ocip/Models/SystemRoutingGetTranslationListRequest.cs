using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the system digit routing table.
    /// The response is either a SystemRoutingGetTranslationListResponse or an ErrorResponse.
        /// <see cref="SystemRoutingGetTranslationListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemRoutingGetTranslationListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
