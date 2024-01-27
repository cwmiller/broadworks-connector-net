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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:13263""}]")]
    public class SystemNumberPortabilityQueryDigitPatternGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _statusDigitPatternTable;

        [XmlElement(ElementName = "statusDigitPatternTable", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:13263")]
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
