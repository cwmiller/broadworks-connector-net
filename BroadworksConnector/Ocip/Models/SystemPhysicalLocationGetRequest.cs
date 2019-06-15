using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the list of Physical Location system parameters.
    /// The response is either SystemPhysicalLocationGetResponse or ErrorResponse.
        /// <see cref="SystemPhysicalLocationGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemPhysicalLocationGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
