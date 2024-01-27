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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:39273""}]")]
    public class SystemVoiceMessagingGroupGetVoicePortalMenusResponse20ForwardOrComposeMessageMenuKeys
    {

        protected string _sendToPerson;

        [XmlElement(ElementName = "sendToPerson", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:39273")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string SendToPerson
        {
            get => _sendToPerson;
            set
            {
                SendToPersonSpecified = true;
                _sendToPerson = value;
            }
        }

        [XmlIgnore]
        protected bool SendToPersonSpecified { get; set; }

        protected string _sendToAllGroupMembers;

        [XmlElement(ElementName = "sendToAllGroupMembers", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:39273")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string SendToAllGroupMembers
        {
            get => _sendToAllGroupMembers;
            set
            {
                SendToAllGroupMembersSpecified = true;
                _sendToAllGroupMembers = value;
            }
        }

        [XmlIgnore]
        protected bool SendToAllGroupMembersSpecified { get; set; }

        protected string _sendToDistributionList;

        [XmlElement(ElementName = "sendToDistributionList", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:39273")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string SendToDistributionList
        {
            get => _sendToDistributionList;
            set
            {
                SendToDistributionListSpecified = true;
                _sendToDistributionList = value;
            }
        }

        [XmlIgnore]
        protected bool SendToDistributionListSpecified { get; set; }

        protected string _changeCurrentIntroductionOrMessage;

        [XmlElement(ElementName = "changeCurrentIntroductionOrMessage", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:39273")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string ChangeCurrentIntroductionOrMessage
        {
            get => _changeCurrentIntroductionOrMessage;
            set
            {
                ChangeCurrentIntroductionOrMessageSpecified = true;
                _changeCurrentIntroductionOrMessage = value;
            }
        }

        [XmlIgnore]
        protected bool ChangeCurrentIntroductionOrMessageSpecified { get; set; }

        protected string _listenToCurrentIntroductionOrMessage;

        [XmlElement(ElementName = "listenToCurrentIntroductionOrMessage", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:39273")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string ListenToCurrentIntroductionOrMessage
        {
            get => _listenToCurrentIntroductionOrMessage;
            set
            {
                ListenToCurrentIntroductionOrMessageSpecified = true;
                _listenToCurrentIntroductionOrMessage = value;
            }
        }

        [XmlIgnore]
        protected bool ListenToCurrentIntroductionOrMessageSpecified { get; set; }

        protected string _setOrClearUrgentIndicator;

        [XmlElement(ElementName = "setOrClearUrgentIndicator", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:39273")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string SetOrClearUrgentIndicator
        {
            get => _setOrClearUrgentIndicator;
            set
            {
                SetOrClearUrgentIndicatorSpecified = true;
                _setOrClearUrgentIndicator = value;
            }
        }

        [XmlIgnore]
        protected bool SetOrClearUrgentIndicatorSpecified { get; set; }

        protected string _setOrClearConfidentialIndicator;

        [XmlElement(ElementName = "setOrClearConfidentialIndicator", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:39273")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string SetOrClearConfidentialIndicator
        {
            get => _setOrClearConfidentialIndicator;
            set
            {
                SetOrClearConfidentialIndicatorSpecified = true;
                _setOrClearConfidentialIndicator = value;
            }
        }

        [XmlIgnore]
        protected bool SetOrClearConfidentialIndicatorSpecified { get; set; }

        protected string _returnToPreviousMenu;

        [XmlElement(ElementName = "returnToPreviousMenu", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:39273")]
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

        [XmlElement(ElementName = "repeatMenu", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:39273")]
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
