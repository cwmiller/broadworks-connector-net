using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models.C
{
    /// <summary>
    /// The ErrorResponse is concrete response sent whenever a transaction fails and does not return any data.
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "C")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""5a0dbb6ff453924acebff71a89ec0dc8:201""}]")]
    public class ErrorResponse : BroadWorksConnector.Ocip.Models.C.OCIResponse
    {

        protected int _errorCode;

        [XmlElement(ElementName = "errorCode", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"5a0dbb6ff453924acebff71a89ec0dc8:201")]
        public int ErrorCode
        {
            get => _errorCode;
            set
            {
                ErrorCodeSpecified = true;
                _errorCode = value;
            }
        }

        [XmlIgnore]
        protected bool ErrorCodeSpecified { get; set; }

        protected string _summary;

        [XmlElement(ElementName = "summary", IsNullable = false, Namespace = "")]
        [Group(@"5a0dbb6ff453924acebff71a89ec0dc8:201")]
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

        protected string _summaryEnglish;

        [XmlElement(ElementName = "summaryEnglish", IsNullable = false, Namespace = "")]
        [Group(@"5a0dbb6ff453924acebff71a89ec0dc8:201")]
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

        protected string _detail;

        [XmlElement(ElementName = "detail", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"5a0dbb6ff453924acebff71a89ec0dc8:201")]
        public string Detail
        {
            get => _detail;
            set
            {
                DetailSpecified = true;
                _detail = value;
            }
        }

        [XmlIgnore]
        protected bool DetailSpecified { get; set; }

    }
}
