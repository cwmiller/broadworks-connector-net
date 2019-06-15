using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the list of all Calling Party Category in system.
    /// The response is either a SystemCallingPartyCategoryGetListResponse or an ErrorResponse.
        /// <see cref="SystemCallingPartyCategoryGetListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemCallingPartyCategoryGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
