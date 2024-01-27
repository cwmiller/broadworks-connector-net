using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to ServiceProviderAlternateUserIdGetListRequest.
    /// The "User Type" column contains the corresponding enumerated UserType value.
    /// Contains a table of alternate user ids, the column headings are:
    /// "User Id", "Alternate User Id", "Group Id" and "User Type".
    /// <see cref="ServiceProviderAlternateUserIdGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e19a9072c2dad499e9f28837da5768db:1730""}]")]
    public class ServiceProviderAlternateUserIdGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _alternateUserIdTable;

        [XmlElement(ElementName = "alternateUserIdTable", IsNullable = false, Namespace = "")]
        [Group(@"e19a9072c2dad499e9f28837da5768db:1730")]
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
