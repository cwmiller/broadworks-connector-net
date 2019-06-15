using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get a list of Attribute Value Pair (AVP) combinations that are
    /// disabled. The response is either a SystemAccountingInhibitedAttributeValuePairCodeGetListResponse or an ErrorResponse.
        /// <see cref="SystemAccountingInhibitedAttributeValuePairCodeGetListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemAccountingInhibitedAttributeValuePairCodeGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
