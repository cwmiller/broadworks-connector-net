using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupInstantGroupCallGetInstanceListRequest.
    /// Contains a 6 column table with column headings:
    /// "Service User Id", "Name", "Phone Number", "Extension", "Department", "Is Active".
    /// The column values for Is Active can either be true, or false.
    /// <see cref="GroupInstantGroupCallGetInstanceListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6c8b59f80404b6283b25be24c263cb12:106""}]")]
    public class GroupInstantGroupCallGetInstanceListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _instantGroupCallTable;

        [XmlElement(ElementName = "instantGroupCallTable", IsNullable = false, Namespace = "")]
        [Group(@"6c8b59f80404b6283b25be24c263cb12:106")]
        public BroadWorksConnector.Ocip.Models.C.OCITable InstantGroupCallTable
        {
            get => _instantGroupCallTable;
            set
            {
                InstantGroupCallTableSpecified = true;
                _instantGroupCallTable = value;
            }
        }

        [XmlIgnore]
        protected bool InstantGroupCallTableSpecified { get; set; }

    }
}
