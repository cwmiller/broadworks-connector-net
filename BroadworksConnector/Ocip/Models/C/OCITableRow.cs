using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models.C
{
    /// <summary>
    /// The OCITableRow type is used in responses only, never in requests. It occurs
    /// inside the OCITable type. The OCITableRow consists columns of strings.
    /// Clients should not assume any particular column order as future
    /// revisions of the protocol may move or add columns. See the OCITable data type
    /// for more information.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "C")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""77f32f6c8e214eb5c1a80dedfce1cb56:230""}]")]
    public class OCITableRow
    {

        private List<string> _col = new List<string>();

        [XmlElement(ElementName = "col", IsNullable = false, Namespace = "")]
        [Group(@"77f32f6c8e214eb5c1a80dedfce1cb56:230")]
        public List<string> Col
        {
            get => _col;
            set
            {
                ColSpecified = true;
                _col = value;
            }
        }

        [XmlIgnore]
        public bool ColSpecified { get; set; }

    }
}
