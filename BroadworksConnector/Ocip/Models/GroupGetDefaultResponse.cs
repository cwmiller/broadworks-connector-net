using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupGetDefaultRequest. All values are default values for a group's profile.
    /// <see cref="GroupGetDefaultRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f3a93cf15de4abd7903673e44ee3e07b:5077""}]")]
    public class GroupGetDefaultResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private string _defaultDomain;

        [XmlElement(ElementName = "defaultDomain", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:5077")]
        [MinLength(1)]
        [MaxLength(80)]
        public string DefaultDomain
        {
            get => _defaultDomain;
            set
            {
                DefaultDomainSpecified = true;
                _defaultDomain = value;
            }
        }

        [XmlIgnore]
        public bool DefaultDomainSpecified { get; set; }

        private int _userLimit;

        [XmlElement(ElementName = "userLimit", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:5077")]
        [MinInclusive(1)]
        [MaxInclusive(999999)]
        public int UserLimit
        {
            get => _userLimit;
            set
            {
                UserLimitSpecified = true;
                _userLimit = value;
            }
        }

        [XmlIgnore]
        public bool UserLimitSpecified { get; set; }

        private string _timeZone;

        [XmlElement(ElementName = "timeZone", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:5077")]
        [MinLength(1)]
        [MaxLength(127)]
        public string TimeZone
        {
            get => _timeZone;
            set
            {
                TimeZoneSpecified = true;
                _timeZone = value;
            }
        }

        [XmlIgnore]
        public bool TimeZoneSpecified { get; set; }

        private string _timeZoneDisplayName;

        [XmlElement(ElementName = "timeZoneDisplayName", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:5077")]
        [MinLength(1)]
        [MaxLength(127)]
        public string TimeZoneDisplayName
        {
            get => _timeZoneDisplayName;
            set
            {
                TimeZoneDisplayNameSpecified = true;
                _timeZoneDisplayName = value;
            }
        }

        [XmlIgnore]
        public bool TimeZoneDisplayNameSpecified { get; set; }

    }
}
