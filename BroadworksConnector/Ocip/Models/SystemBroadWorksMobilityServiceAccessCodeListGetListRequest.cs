using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the list of Service Access Code lists.
    /// The response is either SystemBroadWorksMobilityServiceAccessCodeListGetListResponse or ErrorResponse.
        /// <see cref="SystemBroadWorksMobilityServiceAccessCodeListGetListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemBroadWorksMobilityServiceAccessCodeListGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
