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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:11384""}]")]
    public class SystemHomeNetworkGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected List<string> _mscAddress = new List<string>();

        [XmlElement(ElementName = "mscAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:11384")]
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
