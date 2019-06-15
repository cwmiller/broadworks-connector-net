using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the broadworks mobility system parameters.
    /// The response is either a SystemBroadWorksMobilityGetResponse or an ErrorResponse.
    /// 
    /// Replaced by: SystemBroadWorksMobilityGetRequest17sp4.
        /// <see cref="SystemBroadWorksMobilityGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="SystemBroadWorksMobilityGetRequest17sp4"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemBroadWorksMobilityGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
