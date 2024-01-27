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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:5489""}]")]
    public class SystemClientIdentityGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _clientIdentityTable;

        [XmlElement(ElementName = "clientIdentityTable", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:5489")]
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
