using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the list of all Communication Barring Criteria.
    /// The response is either a SystemCommunicationBarringCriteriaGetListResponse or an ErrorResponse.
        /// <see cref="SystemCommunicationBarringCriteriaGetListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemCommunicationBarringCriteriaGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
