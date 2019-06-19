using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemAlternateUserIdGetListRequest.
    /// The "User Type" column contains the corresponding enumerated UserType value.
    /// Contains a table of alternate user ids, the column headings are:
    /// "User Id", "Alternate User Id", "Group Id", "Organization Id", "Reseller Id" and "User Type".
    /// 
    /// The following columns are only returned in AS data mode:
    /// "Reseller Id"
    /// <see cref="SystemAlternateUserIdGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:1848""}]")]
    public class SystemAlternateUserIdGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _alternateUserIdTable;

        [XmlElement(ElementName = "alternateUserIdTable", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:1848")]
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
        public bool AlternateUserIdTableSpecified { get; set; }

    }
}
