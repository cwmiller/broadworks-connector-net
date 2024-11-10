using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the location of a file in a group’s
    /// Announcement Repository.
    /// The response is either GroupAnnouncementFileLocationGetResponse or ErrorResponse.
        /// <see cref="GroupAnnouncementFileLocationGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""2bd2e9c0ba9fd02c495cbd673527444f:52""}]")]
    public class GroupAnnouncementFileLocationGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.GroupAnnouncementFileLocationGetResponse>
    {
        
        protected string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"2bd2e9c0ba9fd02c495cbd673527444f:52")]
[MinLength(1)]
[MaxLength(30)]
        public string ServiceProviderId {
            get => _serviceProviderId;
            set {
                ServiceProviderIdSpecified = true;
                _serviceProviderId = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceProviderIdSpecified { get; set; }
        
        protected string _groupId;

        [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
        [Group(@"2bd2e9c0ba9fd02c495cbd673527444f:52")]
[MinLength(1)]
[MaxLength(30)]
        public string GroupId {
            get => _groupId;
            set {
                GroupIdSpecified = true;
                _groupId = value;
            }
        }

        [XmlIgnore]
        protected bool GroupIdSpecified { get; set; }
        
        protected BroadWorksConnector.Ocip.Models.AnnouncementFileKey _announcementFileKey;

        [XmlElement(ElementName = "announcementFileKey", IsNullable = false, Namespace = "")]
        [Group(@"2bd2e9c0ba9fd02c495cbd673527444f:52")]
        public BroadWorksConnector.Ocip.Models.AnnouncementFileKey AnnouncementFileKey {
            get => _announcementFileKey;
            set {
                AnnouncementFileKeySpecified = true;
                _announcementFileKey = value;
            }
        }

        [XmlIgnore]
        protected bool AnnouncementFileKeySpecified { get; set; }
        
    }
}
