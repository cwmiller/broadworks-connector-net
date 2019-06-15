using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system level data associated with Call Center.
    /// The response is either a SystemCallCenterGetResponse or an
    /// ErrorResponse.
    /// Replaced By: SystemCallCenterGetRequest14sp9
        /// <see cref="SystemCallCenterGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="SystemCallCenterGetRequest14sp9"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemCallCenterGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
