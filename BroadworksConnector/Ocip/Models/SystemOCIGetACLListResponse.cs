using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemOCIGetACLListRequest.
    /// Returns a 2 coulmn table with column headings:
    /// "Net Address" and "Description".
    /// <see cref="SystemOCIGetACLListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:12493""}]")]
    public class SystemOCIGetACLListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _aclTable;

        [XmlElement(ElementName = "aclTable", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:12493")]
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
