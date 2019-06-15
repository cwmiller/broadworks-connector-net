using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the list of all Communication Barring Incoming Criteria.
    /// The response is either a SystemCommunicationBarringIncomingCriteriaGetListResponse or an ErrorResponse.
        /// <see cref="SystemCommunicationBarringIncomingCriteriaGetListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemCommunicationBarringIncomingCriteriaGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
