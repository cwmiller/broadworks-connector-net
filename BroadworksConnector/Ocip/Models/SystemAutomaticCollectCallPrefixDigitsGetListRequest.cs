using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the system automatic collect call prefix digits lists.
    /// The response is either SystemAutomaticCollectCallPrefixDigitsGetListResponse or ErrorResponse.
    /// <see cref="SystemAutomaticCollectCallPrefixDigitsGetListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""af1b47d7cab3335a81456e64e42371b0:129""}]")]
    public class SystemAutomaticCollectCallPrefixDigitsGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemAutomaticCollectCallPrefixDigitsGetListResponse>
    {

        private string _countryCode;

        [XmlElement(ElementName = "countryCode", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"af1b47d7cab3335a81456e64e42371b0:129")]
        [MaxLength(3)]
        [RegularExpression(@"[0-9]|[1-9][0-9]{1,2}")]
        public string CountryCode
        {
            get => _countryCode;
            set
            {
                CountryCodeSpecified = true;
                _countryCode = value;
            }
        }

        [XmlIgnore]
        protected bool CountryCodeSpecified { get; set; }

    }
}
