using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models.C
{
    /// <summary>
    /// The OCITable type is used in responses only, never in requests.
    /// The table consists of rows and columns of strings. Each column has a column
    /// heading. Clients should search the column headings to find a particular
    /// column. Clients should not assume any particular column order as future
    /// revisions of the protocol may move or add columns.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "C")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""77f32f6c8e214eb5c1a80dedfce1cb56:237""}]")]
    public class OCITable
    {

        protected List<string> _colHeading = new List<string>();

        [XmlElement(ElementName = "colHeading", IsNullable = false, Namespace = "")]
        [Group(@"77f32f6c8e214eb5c1a80dedfce1cb56:237")]
        public List<string> ColHeading
        {
            get => _colHeading;
            set
            {
                ColHeadingSpecified = true;
                _colHeading = value;
            }
        }

        [XmlIgnore]
        protected bool ColHeadingSpecified { get; set; }

        protected List<BroadWorksConnector.Ocip.Models.C.OCITableRow> _row = new List<BroadWorksConnector.Ocip.Models.C.OCITableRow>();

        [XmlElement(ElementName = "row", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"77f32f6c8e214eb5c1a80dedfce1cb56:237")]
        public List<BroadWorksConnector.Ocip.Models.C.OCITableRow> Row
        {
            get => _row;
            set
            {
                RowSpecified = true;
                _row = value;
            }
        }

        [XmlIgnore]
        protected bool RowSpecified { get; set; }

    }
}
