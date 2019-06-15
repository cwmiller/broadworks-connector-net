using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system level data associated with Call Return.
    /// The response is either a SystemCallReturnGetResponse or an
    /// ErrorResponse.
        /// <see cref="SystemCallReturnGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemCallReturnGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
