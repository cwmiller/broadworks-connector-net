using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the list of groups currently associated to the specified Call Recording platform.
    /// The response is either SystemCallRecordingGetPlatformUsageResponse or ErrorResponse.
    /// 
    /// Replaced by SystemCallRecordingGetPlatformUsageRequest22 in AS data mode.
        /// <see cref="SystemCallRecordingGetPlatformUsageResponse"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="SystemCallRecordingGetPlatformUsageRequest22"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemCallRecordingGetPlatformUsageRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _name;

        [XmlElement(ElementName = "name", IsNullable = false, Namespace = "")]
        public string Name {
            get => _name;
            set {
                NameSpecified = true;
                _name = value;
            }
        }

        [XmlIgnore]
        public bool NameSpecified { get; set; }
        
    }
}
