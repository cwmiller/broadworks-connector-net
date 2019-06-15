using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the File System parameters.
    /// The response is either SystemConfigurableFileSystemGetResponse or ErrorResponse.
    /// Replaced by: SystemConfigurableFileSystemGetRequest23
        /// <see cref="SystemConfigurableFileSystemGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="SystemConfigurableFileSystemGetRequest23"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemConfigurableFileSystemGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
