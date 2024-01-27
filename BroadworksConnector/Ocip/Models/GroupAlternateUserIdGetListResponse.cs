using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupAlternateUserIdGetListRequest.
    /// The "User Type" column contains the corresponding enumerated UserType value.
    /// Contains a table of alternate user ids, the column headings are:
    /// "User Id", "Alternate User Id" and "User Type".
    /// <see cref="GroupAlternateUserIdGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4b0e7857796c636464362260a2f8e5ee:1870""}]")]
    public class GroupAlternateUserIdGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _alternateUserIdTable;

        [XmlElement(ElementName = "alternateUserIdTable", IsNullable = false, Namespace = "")]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:1870")]
        public BroadWorksConnector.Ocip.Models.C.OCITable AlternateUserIdTable
        {
            get => _alternateUserIdTable;
            set
            {
                AlternateUserIdTableSpecified = true;
                _alternateUserIdTable = value;
            }
        }

        [XmlIgnore]
        protected bool AlternateUserIdTableSpecified { get; set; }

    }
}
