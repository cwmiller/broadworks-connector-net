using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the list of alternate carriers available for CbC and Preselection.
    /// The response is either a SystemHPBXAlternateCarrierSelectionGetCarrierListResponse or an ErrorResponse.
        /// <see cref="SystemHPBXAlternateCarrierSelectionGetCarrierListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemHPBXAlternateCarrierSelectionGetCarrierListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
