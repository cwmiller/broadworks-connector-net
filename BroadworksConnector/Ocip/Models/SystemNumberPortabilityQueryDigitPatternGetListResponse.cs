using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the SystemNumberPortabilityQueryDigitPatternGetListRequest.
    /// Contains a table with column headings:
    /// "Digit Pattern", "Status".
    /// <see cref="SystemNumberPortabilityQueryDigitPatternGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:13093""}]")]
    public class SystemNumberPortabilityQueryDigitPatternGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _statusDigitPatternTable;

        [XmlElement(ElementName = "statusDigitPatternTable", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:13093")]
        public BroadWorksConnector.Ocip.Models.C.OCITable StatusDigitPatternTable
        {
            get => _statusDigitPatternTable;
            set
            {
                StatusDigitPatternTableSpecified = true;
                _statusDigitPatternTable = value;
            }
        }

        [XmlIgnore]
        protected bool StatusDigitPatternTableSpecified { get; set; }

    }
}
