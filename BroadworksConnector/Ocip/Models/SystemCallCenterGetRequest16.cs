using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system level data associated with Call Center.
    /// The response is either a SystemCallCenterGetResponse16 or an
    /// ErrorResponse.
    /// 
    /// Replaced by: SystemCallCenterGetRequest17
        /// <see cref="SystemCallCenterGetResponse16"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="SystemCallCenterGetRequest17"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemCallCenterGetRequest16 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
