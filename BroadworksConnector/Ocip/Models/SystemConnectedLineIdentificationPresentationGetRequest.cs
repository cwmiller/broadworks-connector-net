using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system level data associated with the COLP service.
    /// The response is either a SystemConnectedLineIdentificationPresentationGetResponse or an
    /// ErrorResponse.
        /// <see cref="SystemConnectedLineIdentificationPresentationGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemConnectedLineIdentificationPresentationGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
