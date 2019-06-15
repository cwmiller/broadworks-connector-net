using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system's automatic callback attributes.
    /// The response is either a SystemAutomaticCallbackGetReleaseCauseListResponse or an ErrorResponse.
        /// <see cref="SystemAutomaticCallbackGetReleaseCauseListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemAutomaticCallbackGetReleaseCauseListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
