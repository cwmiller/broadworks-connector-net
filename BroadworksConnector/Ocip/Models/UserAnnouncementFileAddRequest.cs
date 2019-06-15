using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Add an announcement to the user announcement repository
    /// The response is either a SuccessResponse or an ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserAnnouncementFileAddRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        public string UserId {
            get => _userId;
            set {
                UserIdSpecified = true;
                _userId = value;
            }
        }

        [XmlIgnore]
        public bool UserIdSpecified { get; set; }
        
        private string _announcementFileName;

        [XmlElement(ElementName = "announcementFileName", IsNullable = false, Namespace = "")]
        public string AnnouncementFileName {
            get => _announcementFileName;
            set {
                AnnouncementFileNameSpecified = true;
                _announcementFileName = value;
            }
        }

        [XmlIgnore]
        public bool AnnouncementFileNameSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.LabeledMediaFileResource _announcementFile;

        [XmlElement(ElementName = "announcementFile", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.LabeledMediaFileResource AnnouncementFile {
            get => _announcementFile;
            set {
                AnnouncementFileSpecified = true;
                _announcementFile = value;
            }
        }

        [XmlIgnore]
        public bool AnnouncementFileSpecified { get; set; }
        
    }
}
