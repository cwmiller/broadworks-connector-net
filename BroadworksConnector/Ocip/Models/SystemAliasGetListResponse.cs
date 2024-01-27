using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemAliasGetListRequest. Contains the list of all network alias' for
    /// the Application Server.
    /// <see cref="SystemAliasGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:2295""}]")]
    public class SystemAliasGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected List<string> _aliasNetAddress = new List<string>();

        [XmlElement(ElementName = "aliasNetAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:2295")]
        [MinLength(1)]
        [MaxLength(80)]
        public List<string> AliasNetAddress
        {
            get => _aliasNetAddress;
            set
            {
                AliasNetAddressSpecified = true;
                _aliasNetAddress = value;
            }
        }

        [XmlIgnore]
        protected bool AliasNetAddressSpecified { get; set; }

    }
}
