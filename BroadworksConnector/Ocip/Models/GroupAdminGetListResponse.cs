using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupAdminGetListRequest.
    /// Contains a 7 column table with column headings "Administrator ID",
    /// "Last Name", "First Name", "Department", "Language", "Locale" and "Encoding".
    /// 
    /// The following columns are only returned in AS data mode:
    /// "Locale" and "Encoding"
    /// <see cref="GroupAdminGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4b0e7857796c636464362260a2f8e5ee:1559""}]")]
    public class GroupAdminGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _groupAdminTable;

        [XmlElement(ElementName = "groupAdminTable", IsNullable = false, Namespace = "")]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:1559")]
        public BroadWorksConnector.Ocip.Models.C.OCITable GroupAdminTable
        {
            get => _groupAdminTable;
            set
            {
                GroupAdminTableSpecified = true;
                _groupAdminTable = value;
            }
        }

        [XmlIgnore]
        protected bool GroupAdminTableSpecified { get; set; }

    }
}
