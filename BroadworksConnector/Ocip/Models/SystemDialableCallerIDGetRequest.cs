using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the system level Dialable Caller ID criteria list.
    /// The response is either a SystemDialableCallerIDGetResponse or an ErrorResponse.
        /// <see cref="SystemDialableCallerIDGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemDialableCallerIDGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
