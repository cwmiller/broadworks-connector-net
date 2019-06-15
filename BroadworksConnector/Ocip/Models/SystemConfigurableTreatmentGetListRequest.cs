using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get a list of configurable treatments.
    /// The response is either a SystemConfigurableTreatmentGetListResponse or an ErrorResponse.
        /// <see cref="SystemConfigurableTreatmentGetListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemConfigurableTreatmentGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
