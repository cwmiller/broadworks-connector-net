using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get list of Call Recording platforms.
    /// The response is either SystemCallRecordingGetPlatformListResponse or ErrorResponse.
    /// 
    /// The possible values for "Support Video Rec" can be either true or false.
    /// Schema version values include: 1.0, 2.0, 3.0
    /// 
    /// Replaced by: SystemCallRecordingGetPlatformListRequest20sp1 in AS data mode
    /// <see cref="SystemCallRecordingGetPlatformListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemCallRecordingGetPlatformListRequest20sp1"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]


    public class SystemCallRecordingGetPlatformListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
