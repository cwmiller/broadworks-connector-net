using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// A list of voice mail distribution lists
    /// It is used when setting a user's voice messaging distribution lists
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""1fea1222b6a78aa7b98fd5c41bdae113:3201""}]")]
    public class VoiceMessagingDistributionListModify
    {

        protected int _listId;

        [XmlElement(ElementName = "listId", IsNullable = false, Namespace = "")]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:3201")]
        [MinInclusive(0)]
        [MaxInclusive(14)]
        public int ListId
        {
            get => _listId;
            set
            {
                ListIdSpecified = true;
                _listId = value;
            }
        }

        [XmlIgnore]
        protected bool ListIdSpecified { get; set; }

        protected string _description;

        [XmlElement(ElementName = "description", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:3201")]
        [MinLength(1)]
        [MaxLength(80)]
        public string Description
        {
            get => _description;
            set
            {
                DescriptionSpecified = true;
                _description = value;
            }
        }

        [XmlIgnore]
        protected bool DescriptionSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ReplacementOutgoingDNorSIPURIList _phoneNumberList;

        [XmlElement(ElementName = "phoneNumberList", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:3201")]
        public BroadWorksConnector.Ocip.Models.ReplacementOutgoingDNorSIPURIList PhoneNumberList
        {
            get => _phoneNumberList;
            set
            {
                PhoneNumberListSpecified = true;
                _phoneNumberList = value;
            }
        }

        [XmlIgnore]
        protected bool PhoneNumberListSpecified { get; set; }

    }
}
