using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The message contains the status and error reason that prevents DN to be assigned/validated
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""c0d21ef9ba207c335d8347e5172fce1d:2487""}]")]
    public class DNValidationStatusMessage
    {

        private string _dn;

        [XmlElement(ElementName = "dn", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:2487")]
        [MinLength(1)]
        [MaxLength(23)]
        public string Dn
        {
            get => _dn;
            set
            {
                DnSpecified = true;
                _dn = value;
            }
        }

        [XmlIgnore]
        protected bool DnSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.DNValidationStatus _status;

        [XmlElement(ElementName = "status", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:2487")]
        public BroadWorksConnector.Ocip.Models.DNValidationStatus Status
        {
            get => _status;
            set
            {
                StatusSpecified = true;
                _status = value;
            }
        }

        [XmlIgnore]
        protected bool StatusSpecified { get; set; }

        private int _messageCode;

        [XmlElement(ElementName = "messageCode", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:2487")]
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
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:2487")]
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
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:2487")]
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
