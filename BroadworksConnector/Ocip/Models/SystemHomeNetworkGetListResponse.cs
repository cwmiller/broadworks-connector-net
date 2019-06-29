using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the SystemHomeNetworkGetListRequest.
    /// <see cref="SystemHomeNetworkGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:10222""}]")]
    public class SystemHomeNetworkGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private List<string> _mscAddress = new List<string>();

        [XmlElement(ElementName = "mscAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:10222")]
        [MinLength(1)]
        [MaxLength(23)]
        public List<string> MscAddress
        {
            get => _mscAddress;
            set
            {
                MscAddressSpecified = true;
                _mscAddress = value;
            }
        }

        [XmlIgnore]
        protected bool MscAddressSpecified { get; set; }

    }
}
