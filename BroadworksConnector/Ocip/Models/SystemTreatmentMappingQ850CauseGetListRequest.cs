using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests a table of all the existing Q850 Cause Value Mappings in the system.
    /// The response is either a SystemTreatmentMappingQ850CauseGetListResponse
    /// or an ErrorResponse.
        /// <see cref="SystemTreatmentMappingQ850CauseGetListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemTreatmentMappingQ850CauseGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
