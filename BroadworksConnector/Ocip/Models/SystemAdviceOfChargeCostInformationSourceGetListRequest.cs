using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get a list of cost information sources.
    /// The response is either SystemAdviceOfChargeCostInformationSourceGetListResponse or ErrorResponse.
        /// <see cref="SystemAdviceOfChargeCostInformationSourceGetListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemAdviceOfChargeCostInformationSourceGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
