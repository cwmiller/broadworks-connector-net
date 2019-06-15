using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests the system passcode rules setting.
    /// The response is either SystemPortalPasscodeRulesGetResponse19 or ErrorResponse.
        /// <see cref="SystemPortalPasscodeRulesGetResponse19"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemPortalPasscodeRulesGetRequest19 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
