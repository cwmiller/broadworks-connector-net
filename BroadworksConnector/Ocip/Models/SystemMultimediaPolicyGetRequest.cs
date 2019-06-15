using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system level data associated with Multimedia Policy.
    /// The response is either a SystemMultimediaPolicyGetResponse or an
    /// ErrorResponse.
        /// <see cref="SystemMultimediaPolicyGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemMultimediaPolicyGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
