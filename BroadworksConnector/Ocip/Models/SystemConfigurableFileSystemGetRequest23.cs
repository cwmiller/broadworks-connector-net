using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the File System parameters.
    /// change of behavior is that CLI System/MediaFileSystem/get will no longer show the password
    /// The response is either SystemConfigurableFileSystemGetResponse23 or ErrorResponse.
        /// <see cref="SystemConfigurableFileSystemGetResponse23"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemConfigurableFileSystemGetRequest23 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
