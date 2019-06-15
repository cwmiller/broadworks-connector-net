using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the BroadWorks Mobile Manager service system settings.
    /// The response is either SystemBroadWorksMobileManagerGetResponse or ErrorResponse.
        /// <see cref="SystemBroadWorksMobileManagerGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemBroadWorksMobileManagerGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
