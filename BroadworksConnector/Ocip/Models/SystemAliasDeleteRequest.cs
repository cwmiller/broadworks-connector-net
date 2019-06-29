using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Delete a system-level Application Server alias from the system.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:1770""}]")]
    public class SystemAliasDeleteRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _aliasNetAddress;

        [XmlElement(ElementName = "aliasNetAddress", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:1770")]
        [MinLength(1)]
        [MaxLength(80)]
        public string AliasNetAddress
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
