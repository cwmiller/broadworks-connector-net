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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:35589""}]")]
    public class SystemVoiceMessagingGroupGetVoicePortalMenusResponse20FaxMessagingMenuKeys
    {

        private string _saveFaxMessageAndSkipToNext;

        [XmlElement(ElementName = "saveFaxMessageAndSkipToNext", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:35589")]
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
        public bool SaveFaxMessageAndSkipToNextSpecified { get; set; }

        private string _previousFaxMessage;

        [XmlElement(ElementName = "previousFaxMessage", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:35589")]
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
        public bool PreviousFaxMessageSpecified { get; set; }

        private string _playEnvelope;

        [XmlElement(ElementName = "playEnvelope", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:35589")]
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
        public bool PlayEnvelopeSpecified { get; set; }

        private string _nextFaxMessage;

        [XmlElement(ElementName = "nextFaxMessage", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:35589")]
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
        public bool NextFaxMessageSpecified { get; set; }

        private string _deleteFaxMessage;

        [XmlElement(ElementName = "deleteFaxMessage", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:35589")]
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
        public bool DeleteFaxMessageSpecified { get; set; }

        private string _printFaxMessage;

        [XmlElement(ElementName = "printFaxMessage", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:35589")]
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
        public bool PrintFaxMessageSpecified { get; set; }

        private string _returnToPreviousMenu;

        [XmlElement(ElementName = "returnToPreviousMenu", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:35589")]
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

    }
}
