using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get list of default Feature Access Codes defined on system level.
    /// The response is either SystemFeatureAccessCodeGetListResponse or ErrorResponse.
    /// 
    /// Replaced by: SystemFeatureAccessCodeGetListRequest21 in AS data mode
        /// <see cref="SystemFeatureAccessCodeGetListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="SystemFeatureAccessCodeGetListRequest21"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemFeatureAccessCodeGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
