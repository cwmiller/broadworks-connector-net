using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get list of Call Recording platforms.
    /// The response is either SystemCallRecordingGetPlatformListResponse20sp1 or ErrorResponse.
    /// 
    /// The possible values for "Support Video Rec" can be either true or false.
    /// Schema version values include: 1.0, 2.0, 3.0
    /// 
    /// Replaced by SystemCallRecordingGetPlatformListRequest22 in AS data mode.
        /// <see cref="SystemCallRecordingGetPlatformListResponse20sp1"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="SystemCallRecordingGetPlatformListRequest22"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemCallRecordingGetPlatformListRequest20sp1 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
