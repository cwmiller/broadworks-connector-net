using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system level data associated with Call Recording.
    /// The response is either a SystemCallRecordingGetResponse or an
    /// ErrorResponse.
    /// 
    /// Replaced by: SystemCallRecordingGetRequest22
        /// <see cref="SystemCallRecordingGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="SystemCallRecordingGetRequest22"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemCallRecordingGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
