using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemExternalAuthenticationGetACLListRequest. The table columns are:
    /// "Net Address" and "Description".
    /// <see cref="SystemExternalAuthenticationGetACLListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:10193""}]")]
    public class SystemExternalAuthenticationGetACLListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _aclTable;

        [XmlElement(ElementName = "aclTable", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:10193")]
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
