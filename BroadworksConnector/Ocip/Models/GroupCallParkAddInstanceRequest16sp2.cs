using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Adds a Call Park group.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7a925e891158dfa3cb1319e045608894:55""}]")]
    public class GroupCallParkAddInstanceRequest16sp2 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"7a925e891158dfa3cb1319e045608894:55")]
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

        private string _groupId;

        [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
        [Group(@"7a925e891158dfa3cb1319e045608894:55")]
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

        private string _name;

        [XmlElement(ElementName = "name", IsNullable = false, Namespace = "")]
        [Group(@"7a925e891158dfa3cb1319e045608894:55")]
        [MinLength(1)]
        [MaxLength(80)]
        public string Name
        {
            get => _name;
            set
            {
                NameSpecified = true;
                _name = value;
            }
        }

        [XmlIgnore]
        protected bool NameSpecified { get; set; }

        private List<string> _userId = new List<string>();

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7a925e891158dfa3cb1319e045608894:55")]
        [MinLength(1)]
        [MaxLength(161)]
        public List<string> UserId
        {
            get => _userId;
            set
            {
                UserIdSpecified = true;
                _userId = value;
            }
        }

        [XmlIgnore]
        protected bool UserIdSpecified { get; set; }

        private string _recallAlternateUserId;

        [XmlElement(ElementName = "recallAlternateUserId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7a925e891158dfa3cb1319e045608894:55")]
        [MinLength(1)]
        [MaxLength(161)]
        public string RecallAlternateUserId
        {
            get => _recallAlternateUserId;
            set
            {
                RecallAlternateUserIdSpecified = true;
                _recallAlternateUserId = value;
            }
        }

        [XmlIgnore]
        protected bool RecallAlternateUserIdSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CallParkRecallTo _recallTo;

        [XmlElement(ElementName = "recallTo", IsNullable = false, Namespace = "")]
        [Group(@"7a925e891158dfa3cb1319e045608894:55")]
        public BroadWorksConnector.Ocip.Models.CallParkRecallTo RecallTo
        {
            get => _recallTo;
            set
            {
                RecallToSpecified = true;
                _recallTo = value;
            }
        }

        [XmlIgnore]
        protected bool RecallToSpecified { get; set; }

    }
}
