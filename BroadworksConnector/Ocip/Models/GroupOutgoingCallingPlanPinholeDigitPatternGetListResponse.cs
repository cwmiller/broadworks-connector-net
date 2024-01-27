using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupOutgoingCallingPlanPinholeDigitPatternGetListRequest.
    /// Contains a table with column headings: "Name", "Digit Pattern".
    /// <see cref="GroupOutgoingCallingPlanPinholeDigitPatternGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""a63afa661ee5c74f4700e562e88c66d0:528""}]")]
    public class GroupOutgoingCallingPlanPinholeDigitPatternGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _digitPatternTable;

        [XmlElement(ElementName = "digitPatternTable", IsNullable = false, Namespace = "")]
        [Group(@"a63afa661ee5c74f4700e562e88c66d0:528")]
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
