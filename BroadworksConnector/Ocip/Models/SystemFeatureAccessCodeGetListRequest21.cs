using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get list of default Feature Access Codes defined on system
    /// level.
    /// The response is either SystemFeatureAccessCodeGetListResponse20 or
    /// ErrorResponse.
    /// 
    /// In release 20 the "Call Recording" FAC name is changed to
    /// "Call Recording - Start".
        /// <see cref="SystemFeatureAccessCodeGetListResponse20"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemFeatureAccessCodeGetListRequest21 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
