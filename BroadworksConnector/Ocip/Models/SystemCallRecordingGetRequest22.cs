using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system level data associated with Call Recording.
    /// The response is either a SystemCallRecordingGetResponse22 or an
    /// ErrorResponse.
        /// <see cref="SystemCallRecordingGetResponse22"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemCallRecordingGetRequest22 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
