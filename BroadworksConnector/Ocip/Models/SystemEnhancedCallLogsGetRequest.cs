using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system level data associated with Enhanced Call Logs.
    /// The response is either a SystemEnhancedCallLogsGetResponse or an
    /// ErrorResponse.
        /// <see cref="SystemEnhancedCallLogsGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemEnhancedCallLogsGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
