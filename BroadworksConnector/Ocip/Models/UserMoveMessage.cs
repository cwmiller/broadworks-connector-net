using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The message describes the impact made when moving a user from one group to another group within the enterprise. The message could also contain the error condition that prevents the user move.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""53d18cc797d03d802cbc411ad821f1d4:4445""}]")]
    public class UserMoveMessage
    {

        private int _messageCode;

        [XmlElement(ElementName = "messageCode", IsNullable = false, Namespace = "")]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:4445")]
        public int MessageCode
        {
            get => _messageCode;
            set
            {
                MessageCodeSpecified = true;
                _messageCode = value;
            }
        }

        [XmlIgnore]
        protected bool MessageCodeSpecified { get; set; }

        private string _summary;

        [XmlElement(ElementName = "summary", IsNullable = false, Namespace = "")]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:4445")]
        public string Summary
        {
            get => _summary;
            set
            {
                SummarySpecified = true;
                _summary = value;
            }
        }

        [XmlIgnore]
        protected bool SummarySpecified { get; set; }

        private string _summaryEnglish;

        [XmlElement(ElementName = "summaryEnglish", IsNullable = false, Namespace = "")]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:4445")]
        public string SummaryEnglish
        {
            get => _summaryEnglish;
            set
            {
                SummaryEnglishSpecified = true;
                _summaryEnglish = value;
            }
        }

        [XmlIgnore]
        protected bool SummaryEnglishSpecified { get; set; }

    }
}
