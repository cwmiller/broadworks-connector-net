using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemClientIdentityGetListRequest.
    /// Returns a table with column headings:
    /// "Client Identity".
    /// <see cref="SystemClientIdentityGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:5409""}]")]
    public class SystemClientIdentityGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _clientIdentityTable;

        [XmlElement(ElementName = "clientIdentityTable", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:5409")]
        public BroadWorksConnector.Ocip.Models.C.OCITable ClientIdentityTable
        {
            get => _clientIdentityTable;
            set
            {
                ClientIdentityTableSpecified = true;
                _clientIdentityTable = value;
            }
        }

        [XmlIgnore]
        protected bool ClientIdentityTableSpecified { get; set; }

    }
}
