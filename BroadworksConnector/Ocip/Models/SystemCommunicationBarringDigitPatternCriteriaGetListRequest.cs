using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the list of all Digit Pattern Criteria defined at the system level.
    /// The response is either a SystemCommunicationBarringDigitPatternCriteriaGetListResponse or an ErrorResponse.
        /// <see cref="SystemCommunicationBarringDigitPatternCriteriaGetListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemCommunicationBarringDigitPatternCriteriaGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
