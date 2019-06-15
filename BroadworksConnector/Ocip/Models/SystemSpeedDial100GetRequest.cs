using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the speed dial 100 system-wide default setting.
    /// The response is either a SystemSpeedDial100GetResponse or an ErrorResponse.
    /// 
    /// Replaced by: SystemSpeedDial100GetRequest17sp1
        /// <see cref="SystemSpeedDial100GetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="SystemSpeedDial100GetRequest17sp1"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemSpeedDial100GetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
