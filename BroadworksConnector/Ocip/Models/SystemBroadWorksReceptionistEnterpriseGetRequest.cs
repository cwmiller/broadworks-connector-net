using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the list of BroadWorks Receptionist - Enterprise parameters.
    /// The response is either SystemBroadWorksReceptionistEnterpriseGetResponse or ErrorResponse.
        /// <see cref="SystemBroadWorksReceptionistEnterpriseGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemBroadWorksReceptionistEnterpriseGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
