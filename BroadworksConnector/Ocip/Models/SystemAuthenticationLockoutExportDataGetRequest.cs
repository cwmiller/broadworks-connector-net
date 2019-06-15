using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to export system wide authentication lockout data to a file. All locked out device profiles, sip endpoints, and sip trunk groups are returned.
    /// The response is either a SuccessResponse or an ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemAuthenticationLockoutExportDataGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _fileName;

        [XmlElement(ElementName = "fileName", IsNullable = false, Namespace = "")]
        public string FileName {
            get => _fileName;
            set {
                FileNameSpecified = true;
                _fileName = value;
            }
        }

        [XmlIgnore]
        public bool FileNameSpecified { get; set; }
        
    }
}
