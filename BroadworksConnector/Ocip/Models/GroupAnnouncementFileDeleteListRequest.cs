using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Delete one or more announcements from the group announcement repository
    /// 
    /// The following elements are only used in AS data mode and ignored in XS data mode:
    /// groupExternalId
    /// announcementFileExternalId
    /// 
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4b0e7857796c636464362260a2f8e5ee:1923"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""4b0e7857796c636464362260a2f8e5ee:1924"",""children"":[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4b0e7857796c636464362260a2f8e5ee:1925""},{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4b0e7857796c636464362260a2f8e5ee:1930""}]}]}]")]
    public class GroupAnnouncementFileDeleteListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:1925")]
        [MinLength(1)]
        [MaxLength(30)]
        public string ServiceProviderId
        {
            get => _serviceProviderId;
            set
            {
                ServiceProviderIdSpecified = true;
                _serviceProviderId = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceProviderIdSpecified { get; set; }

        protected string _groupId;

        [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:1925")]
        [MinLength(1)]
        [MaxLength(30)]
        public string GroupId
        {
            get => _groupId;
            set
            {
                GroupIdSpecified = true;
                _groupId = value;
            }
        }

        [XmlIgnore]
        protected bool GroupIdSpecified { get; set; }

        protected List<BroadWorksConnector.Ocip.Models.AnnouncementFileKey> _announcementFileKey = new List<BroadWorksConnector.Ocip.Models.AnnouncementFileKey>();

        [XmlElement(ElementName = "announcementFileKey", IsNullable = false, Namespace = "")]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:1925")]
        public List<BroadWorksConnector.Ocip.Models.AnnouncementFileKey> AnnouncementFileKey
        {
            get => _announcementFileKey;
            set
            {
                AnnouncementFileKeySpecified = true;
                _announcementFileKey = value;
            }
        }

        [XmlIgnore]
        protected bool AnnouncementFileKeySpecified { get; set; }

        protected string _groupExternalId;

        [XmlElement(ElementName = "groupExternalId", IsNullable = false, Namespace = "")]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:1930")]
        [MaxLength(36)]
        public string GroupExternalId
        {
            get => _groupExternalId;
            set
            {
                GroupExternalIdSpecified = true;
                _groupExternalId = value;
            }
        }

        [XmlIgnore]
        protected bool GroupExternalIdSpecified { get; set; }

        protected List<string> _announcementFileExternalId = new List<string>();

        [XmlElement(ElementName = "announcementFileExternalId", IsNullable = false, Namespace = "")]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:1930")]
        [MaxLength(36)]
        public List<string> AnnouncementFileExternalId
        {
            get => _announcementFileExternalId;
            set
            {
                AnnouncementFileExternalIdSpecified = true;
                _announcementFileExternalId = value;
            }
        }

        [XmlIgnore]
        protected bool AnnouncementFileExternalIdSpecified { get; set; }

    }
}
