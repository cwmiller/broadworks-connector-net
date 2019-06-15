using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests the system passcode rules setting.
    /// The response is either SystemPortalPasscodeRulesGetResponse or ErrorResponse.
    /// 
    /// Replaced by: SystemPortalPasscodeRulesGetRequest19
        /// <see cref="SystemPortalPasscodeRulesGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="SystemPortalPasscodeRulesGetRequest19"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemPortalPasscodeRulesGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
