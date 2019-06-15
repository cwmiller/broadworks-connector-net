using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the list of SIP Diversion Cause values.
    /// The response is either a SystemSIPDiversionReasonGetResponse or ErrorResponse.
        /// <see cref="SystemSIPDiversionReasonGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemSIPDiversionReasonGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
