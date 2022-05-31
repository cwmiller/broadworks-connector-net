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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""00a30b95794e8eb54c36eccd0a6188fa:97""}]")]
    public class GroupCallingPlanGetDigitPatternListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _digitPatternTable;

        [XmlElement(ElementName = "digitPatternTable", IsNullable = false, Namespace = "")]
        [Group(@"00a30b95794e8eb54c36eccd0a6188fa:97")]
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
