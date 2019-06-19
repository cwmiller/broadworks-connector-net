using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to a SystemCommunicationBarringAlternateCallIndicatorGetListRequest. Contains a table with one row per Communication Barring Alternate Call Indicator.  The table column headings are: "Alternate Call Indicator" and "Network Server Alternate Call Indicator".
    /// <see cref="SystemCommunicationBarringAlternateCallIndicatorGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:5244""}]")]
    public class SystemCommunicationBarringAlternateCallIndicatorGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _alternateCallIndicatorTable;

        [XmlElement(ElementName = "alternateCallIndicatorTable", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:5244")]
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
