using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupThirdPartyVoiceMailSupportGetRequest.
    /// <see cref="GroupThirdPartyVoiceMailSupportGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""21e97b8199c6e7eff29a84874335b46e:69""}]")]
    public class GroupThirdPartyVoiceMailSupportGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _isActive;

        [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
        [Group(@"21e97b8199c6e7eff29a84874335b46e:69")]
        public bool IsActive
        {
            get => _isActive;
            set
            {
                IsActiveSpecified = true;
                _isActive = value;
            }
        }

        [XmlIgnore]
        protected bool IsActiveSpecified { get; set; }

        protected string _groupServer;

        [XmlElement(ElementName = "groupServer", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"21e97b8199c6e7eff29a84874335b46e:69")]
        [MinLength(1)]
        [MaxLength(161)]
        public string GroupServer
        {
            get => _groupServer;
            set
            {
                GroupServerSpecified = true;
                _groupServer = value;
            }
        }

        [XmlIgnore]
        protected bool GroupServerSpecified { get; set; }

    }
}
