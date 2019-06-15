using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models.C
{
    /// <summary>
    /// The SuccessResponse is concrete response sent whenever a transaction is successful and does not return any data.
        /// <see cref="SuccessResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "C")]
     
    public class SuccessResponse : BroadWorksConnector.Ocip.Models.C.OCIResponse
    {

        
    }
}
