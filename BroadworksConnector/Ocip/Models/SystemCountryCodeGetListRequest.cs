using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request data for all country codes.
    /// The response is either a SystemCountryCodeGetListResponse or an
    /// ErrorResponse.
        /// <see cref="SystemCountryCodeGetListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemCountryCodeGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
