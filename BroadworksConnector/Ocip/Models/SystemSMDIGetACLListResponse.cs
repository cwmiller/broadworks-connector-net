using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemSMDIGetACLListRequest. The table columns are:
    /// "Net Address" and "Description".
    /// <see cref="SystemSMDIGetACLListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:17669""}]")]
    public class SystemSMDIGetACLListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _aclTable;

        [XmlElement(ElementName = "aclTable", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:17669")]
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
