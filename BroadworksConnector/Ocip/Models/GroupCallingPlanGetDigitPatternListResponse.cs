using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupCallingPlanGetDigitPatternListRequest.
    /// Contains a table with column headings: "Name", "Digit Pattern".
    /// <see cref="GroupCallingPlanGetDigitPatternListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4e20c63d19559e7dea5e6306aa6fbd0a:97""}]")]
    public class GroupCallingPlanGetDigitPatternListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _digitPatternTable;

        [XmlElement(ElementName = "digitPatternTable", IsNullable = false, Namespace = "")]
        [Group(@"4e20c63d19559e7dea5e6306aa6fbd0a:97")]
        public BroadWorksConnector.Ocip.Models.C.OCITable DigitPatternTable
        {
            get => _digitPatternTable;
            set
            {
                DigitPatternTableSpecified = true;
                _digitPatternTable = value;
            }
        }

        [XmlIgnore]
        protected bool DigitPatternTableSpecified { get; set; }

    }
}
