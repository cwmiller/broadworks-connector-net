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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6f793dfca9bd3d121bb35e0f9cf1cb2e:529""}]")]
    public class GroupOutgoingCallingPlanPinholeDigitPatternGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _digitPatternTable;

        [XmlElement(ElementName = "digitPatternTable", IsNullable = false, Namespace = "")]
        [Group(@"6f793dfca9bd3d121bb35e0f9cf1cb2e:529")]
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
