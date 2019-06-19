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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""3347d430e0d5c93a9ff8dcf0e3b60d6c:841""}]")]
    public class SystemVoiceMessagingGroupGetVoicePortalMenusResponse21PersonalizedNameMenuKeys
    {

        private string _recordNewPersonalizedName;

        [XmlElement(ElementName = "recordNewPersonalizedName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:841")]
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
        public bool RecordNewPersonalizedNameSpecified { get; set; }

        private string _listenToCurrentPersonalizedName;

        [XmlElement(ElementName = "listenToCurrentPersonalizedName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:841")]
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
        public bool ListenToCurrentPersonalizedNameSpecified { get; set; }

        private string _deletePersonalizedName;

        [XmlElement(ElementName = "deletePersonalizedName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:841")]
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
        public bool DeletePersonalizedNameSpecified { get; set; }

        private string _returnToPreviousMenu;

        [XmlElement(ElementName = "returnToPreviousMenu", IsNullable = false, Namespace = "")]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:841")]
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
        public bool ReturnToPreviousMenuSpecified { get; set; }

        private string _repeatMenu;

        [XmlElement(ElementName = "repeatMenu", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:841")]
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
        public bool RepeatMenuSpecified { get; set; }

    }
}
