using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system level data associated with Selective Services.
    /// The response is either a SystemSelectiveServicesGetResponse or an
    /// ErrorResponse.
        /// <see cref="SystemSelectiveServicesGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemSelectiveServicesGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
