using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemSIPGetACLListRequest. The table columns are:
    /// "Net Address", "Transport" and "Description".
    /// <see cref="SystemSIPGetACLListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:17540""}]")]
    public class SystemSIPGetACLListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _aclTable;

        [XmlElement(ElementName = "aclTable", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:17540")]
        public BroadWorksConnector.Ocip.Models.C.OCITable AclTable
        {
            get => _aclTable;
            set
            {
                AclTableSpecified = true;
                _aclTable = value;
            }
        }

        [XmlIgnore]
        protected bool AclTableSpecified { get; set; }

    }
}
