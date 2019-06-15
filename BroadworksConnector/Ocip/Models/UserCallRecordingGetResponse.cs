using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the UserCallRecordingGetRequest.
    /// The response contains the user's Call Recording option information.
        /// <see cref="UserCallRecordingGetRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserCallRecordingGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.RecordingOption _recordingOption;

        [XmlElement(ElementName = "recordingOption", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.RecordingOption RecordingOption {
            get => _recordingOption;
            set {
                RecordingOptionSpecified = true;
                _recordingOption = value;
            }
        }

        [XmlIgnore]
        public bool RecordingOptionSpecified { get; set; }
        
    }
}
