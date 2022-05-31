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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""43afb2158d313a1d1a148124d7caba1e:167""}]")]
    public class GroupFlexibleSeatingHostGetInstanceListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _flexibleSeatingHostTable;

        [XmlElement(ElementName = "flexibleSeatingHostTable", IsNullable = false, Namespace = "")]
        [Group(@"43afb2158d313a1d1a148124d7caba1e:167")]
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
