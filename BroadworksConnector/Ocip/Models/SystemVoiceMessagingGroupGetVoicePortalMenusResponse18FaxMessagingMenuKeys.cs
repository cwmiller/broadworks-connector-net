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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:37754""}]")]
    public class SystemVoiceMessagingGroupGetVoicePortalMenusResponse18FaxMessagingMenuKeys
    {

        protected string _saveFaxMessageAndSkipToNext;

        [XmlElement(ElementName = "saveFaxMessageAndSkipToNext", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:37754")]
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

        protected string _previousFaxMessage;

        [XmlElement(ElementName = "previousFaxMessage", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:37754")]
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

        protected string _playEnvelope;

        [XmlElement(ElementName = "playEnvelope", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:37754")]
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

        protected string _nextFaxMessage;

        [XmlElement(ElementName = "nextFaxMessage", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:37754")]
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

        protected string _deleteFaxMessage;

        [XmlElement(ElementName = "deleteFaxMessage", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:37754")]
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

        protected string _printFaxMessage;

        [XmlElement(ElementName = "printFaxMessage", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:37754")]
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

        protected string _returnToPreviousMenu;

        [XmlElement(ElementName = "returnToPreviousMenu", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:37754")]
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
