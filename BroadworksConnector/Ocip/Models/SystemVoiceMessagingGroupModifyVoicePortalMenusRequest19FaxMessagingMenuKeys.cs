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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""3347d430e0d5c93a9ff8dcf0e3b60d6c:1583""}]")]
    public class SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19FaxMessagingMenuKeys
    {

        private string _saveFaxMessageAndSkipToNext;

        [XmlElement(ElementName = "saveFaxMessageAndSkipToNext", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:1583")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string SaveFaxMessageAndSkipToNext
        {
            get => _saveFaxMessageAndSkipToNext;
            set
            {
                SaveFaxMessageAndSkipToNextSpecified = true;
                _saveFaxMessageAndSkipToNext = value;
            }
        }

        [XmlIgnore]
        protected bool SaveFaxMessageAndSkipToNextSpecified { get; set; }

        private string _previousFaxMessage;

        [XmlElement(ElementName = "previousFaxMessage", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:1583")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string PreviousFaxMessage
        {
            get => _previousFaxMessage;
            set
            {
                PreviousFaxMessageSpecified = true;
                _previousFaxMessage = value;
            }
        }

        [XmlIgnore]
        protected bool PreviousFaxMessageSpecified { get; set; }

        private string _playEnvelope;

        [XmlElement(ElementName = "playEnvelope", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:1583")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string PlayEnvelope
        {
            get => _playEnvelope;
            set
            {
                PlayEnvelopeSpecified = true;
                _playEnvelope = value;
            }
        }

        [XmlIgnore]
        protected bool PlayEnvelopeSpecified { get; set; }

        private string _nextFaxMessage;

        [XmlElement(ElementName = "nextFaxMessage", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:1583")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string NextFaxMessage
        {
            get => _nextFaxMessage;
            set
            {
                NextFaxMessageSpecified = true;
                _nextFaxMessage = value;
            }
        }

        [XmlIgnore]
        protected bool NextFaxMessageSpecified { get; set; }

        private string _deleteFaxMessage;

        [XmlElement(ElementName = "deleteFaxMessage", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:1583")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string DeleteFaxMessage
        {
            get => _deleteFaxMessage;
            set
            {
                DeleteFaxMessageSpecified = true;
                _deleteFaxMessage = value;
            }
        }

        [XmlIgnore]
        protected bool DeleteFaxMessageSpecified { get; set; }

        private string _printFaxMessage;

        [XmlElement(ElementName = "printFaxMessage", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:1583")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string PrintFaxMessage
        {
            get => _printFaxMessage;
            set
            {
                PrintFaxMessageSpecified = true;
                _printFaxMessage = value;
            }
        }

        [XmlIgnore]
        protected bool PrintFaxMessageSpecified { get; set; }

        private string _returnToPreviousMenu;

        [XmlElement(ElementName = "returnToPreviousMenu", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:1583")]
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

    }
}
