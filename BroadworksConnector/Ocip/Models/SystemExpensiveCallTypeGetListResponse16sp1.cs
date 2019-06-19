using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemExpensiveCallTypeGetListRequest16sp1.
    /// The column headings are:
    /// "Alternate Call Indicator", "Treatment Audio File".
    /// <see cref="SystemExpensiveCallTypeGetListRequest16sp1"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:8865""}]")]
    public class SystemExpensiveCallTypeGetListResponse16sp1 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _alternateCallIndicatorTable;

        [XmlElement(ElementName = "alternateCallIndicatorTable", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:8865")]
        public BroadWorksConnector.Ocip.Models.C.OCITable AlternateCallIndicatorTable
        {
            get => _alternateCallIndicatorTable;
            set
            {
                AlternateCallIndicatorTableSpecified = true;
                _alternateCallIndicatorTable = value;
            }
        }

        [XmlIgnore]
        public bool AlternateCallIndicatorTableSpecified { get; set; }

    }
}
