using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Add an announcement to the group announcement repository
    /// The response is either a SuccessResponse or an ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupAnnouncementFileAddRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        public string ServiceProviderId {
            get => _serviceProviderId;
            set {
                ServiceProviderIdSpecified = true;
                _serviceProviderId = value;
            }
        }

        [XmlIgnore]
        public bool ServiceProviderIdSpecified { get; set; }
        
        private string _groupId;

        [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
        public string GroupId {
            get => _groupId;
            set {
                GroupIdSpecified = true;
                _groupId = value;
            }
        }

        [XmlIgnore]
        public bool GroupIdSpecified { get; set; }
        
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
