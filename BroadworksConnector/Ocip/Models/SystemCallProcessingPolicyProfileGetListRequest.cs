using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the list of all Call Processing Policy Profiles.
    /// The response is either a SystemCallProcessingPolicyProfileGetListResponse
    /// or an ErrorResponse.
        /// <see cref="SystemCallProcessingPolicyProfileGetListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemCallProcessingPolicyProfileGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
