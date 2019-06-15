using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system level data associated with Selective Services.
    /// The response is either a SystemSelectiveServicesGetResponse18sp1 or an
    /// ErrorResponse.
        /// <see cref="SystemSelectiveServicesGetResponse18sp1"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemSelectiveServicesGetRequest18sp1 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
