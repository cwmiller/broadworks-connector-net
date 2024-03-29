using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""1fea1222b6a78aa7b98fd5c41bdae113:1369""}]")]
    public class SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19PersonalizedNameMenuKeys
    {

        protected string _recordNewPersonalizedName;

        [XmlElement(ElementName = "recordNewPersonalizedName", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:1369")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string RecordNewPersonalizedName
        {
            get => _recordNewPersonalizedName;
            set
            {
                RecordNewPersonalizedNameSpecified = true;
                _recordNewPersonalizedName = value;
            }
        }

        [XmlIgnore]
        protected bool RecordNewPersonalizedNameSpecified { get; set; }

        protected string _listenToCurrentPersonalizedName;

        [XmlElement(ElementName = "listenToCurrentPersonalizedName", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:1369")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string ListenToCurrentPersonalizedName
        {
            get => _listenToCurrentPersonalizedName;
            set
            {
                ListenToCurrentPersonalizedNameSpecified = true;
                _listenToCurrentPersonalizedName = value;
            }
        }

        [XmlIgnore]
        protected bool ListenToCurrentPersonalizedNameSpecified { get; set; }

        protected string _deletePersonalizedName;

        [XmlElement(ElementName = "deletePersonalizedName", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:1369")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string DeletePersonalizedName
        {
            get => _deletePersonalizedName;
            set
            {
                DeletePersonalizedNameSpecified = true;
                _deletePersonalizedName = value;
            }
        }

        [XmlIgnore]
        protected bool DeletePersonalizedNameSpecified { get; set; }

        protected string _returnToPreviousMenu;

        [XmlElement(ElementName = "returnToPreviousMenu", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:1369")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string ReturnToPreviousMenu
        {
            get => _returnToPreviousMenu;
            set
            {
                ReturnToPreviousMenuSpecified = true;
                _returnToPreviousMenu = value;
            }
        }

        [XmlIgnore]
        protected bool ReturnToPreviousMenuSpecified { get; set; }

        protected string _repeatMenu;

        [XmlElement(ElementName = "repeatMenu", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:1369")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string RepeatMenu
        {
            get => _repeatMenu;
            set
            {
                RepeatMenuSpecified = true;
                _repeatMenu = value;
            }
        }

        [XmlIgnore]
        protected bool RepeatMenuSpecified { get; set; }

    }
}
