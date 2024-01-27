using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupFlexibleSeatingHostGetInstanceListRequest.
    /// Contains a table with column headings:
    /// "Service User Id", "Name", "Phone Number", "Extension", "Department", "Is Active".
    /// The column value for "Is Active" can either be true, or false.
    /// <see cref="GroupFlexibleSeatingHostGetInstanceListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""1d4e390f8cd01ca6f92589024d74dac6:166""}]")]
    public class GroupFlexibleSeatingHostGetInstanceListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _flexibleSeatingHostTable;

        [XmlElement(ElementName = "flexibleSeatingHostTable", IsNullable = false, Namespace = "")]
        [Group(@"1d4e390f8cd01ca6f92589024d74dac6:166")]
        public BroadWorksConnector.Ocip.Models.C.OCITable FlexibleSeatingHostTable
        {
            get => _flexibleSeatingHostTable;
            set
            {
                FlexibleSeatingHostTableSpecified = true;
                _flexibleSeatingHostTable = value;
            }
        }

        [XmlIgnore]
        protected bool FlexibleSeatingHostTableSpecified { get; set; }

    }
}
