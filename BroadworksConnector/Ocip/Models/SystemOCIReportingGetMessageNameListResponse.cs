using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemOCIReportingGetMessageNameListRequest.
    /// <see cref="SystemOCIReportingGetMessageNameListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:13772""}]")]
    public class SystemOCIReportingGetMessageNameListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private List<string> _messageNameStartsWith = new List<string>();

        [XmlElement(ElementName = "messageNameStartsWith", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:13772")]
        [MinLength(1)]
        [MaxLength(256)]
        public List<string> MessageNameStartsWith
        {
            get => _messageNameStartsWith;
            set
            {
                MessageNameStartsWithSpecified = true;
                _messageNameStartsWith = value;
            }
        }

        [XmlIgnore]
        protected bool MessageNameStartsWithSpecified { get; set; }

    }
}
