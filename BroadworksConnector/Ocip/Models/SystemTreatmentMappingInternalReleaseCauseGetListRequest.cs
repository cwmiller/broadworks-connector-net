using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests a table of all the Internal Release Cause mappings in the system.
    /// The response is either a SystemTreatmentMappingInternalReleaseCauseGetListResponse
    /// or an ErrorResponse.
        /// <see cref="SystemTreatmentMappingInternalReleaseCauseGetListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemTreatmentMappingInternalReleaseCauseGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
