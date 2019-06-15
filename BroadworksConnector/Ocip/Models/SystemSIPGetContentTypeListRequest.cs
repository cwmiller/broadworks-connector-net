using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the content type list for the SIP interface.
    /// The response is either SystemSIPGetContentTypeListResponse or ErrorResponse.
        /// <see cref="SystemSIPGetContentTypeListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemSIPGetContentTypeListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
