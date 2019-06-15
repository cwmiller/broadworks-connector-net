using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system's digit collection attributes.
    /// The response is either a SystemDigitCollectionGetResponse13mp4 or an ErrorResponse.
        /// <see cref="SystemDigitCollectionGetResponse13mp4"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemDigitCollectionGetRequest13mp4 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
